using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    public class AccountController : Controller
    {
        private ApplicationContext db;
        private SignInManager<User> signInManager;
        private UserManager<User> userManager;
        private readonly IStringLocalizer<AccountController> localizer;

        public AccountController(ApplicationContext applicationContext,SignInManager<User> signInManager,
            UserManager<User> userManager,IStringLocalizer<AccountController> localizer)
        {
            db = applicationContext;
            this.signInManager = signInManager;
            this.userManager = userManager;
            this.localizer = localizer;
        }

        [HttpGet]
        public async Task<IActionResult> Register()
        {
            SetViewBag();
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            SetViewBag();
            User userFromDatabaseByEmail = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            User userFromDatabaseByNickname = await db.Users.FirstOrDefaultAsync(u => u.Nickname == model.Nickname);
            bool isAllValid = true;

            if (string.IsNullOrEmpty(model.Email))
            {
                ViewBag.EmailMessage = localizer["FillInTheField"];
                isAllValid = false;
            }

            if (string.IsNullOrEmpty(model.Nickname))
            {
                ViewBag.NicknameMessage = localizer["FillInTheField"];
                isAllValid = false;
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                ViewBag.PasswordMessage = localizer["FillInTheField"];
                isAllValid = false;
            }

            if (string.IsNullOrEmpty(model.ConfirmPassword))
            {
                ViewBag.ConfirmPasswordMessage = localizer["FillInTheField"];
                isAllValid = false;
            } 

            if(model.Password != model.ConfirmPassword)
            {
                ViewBag.ConfirmPasswordMessage = localizer["PasswordMismatch"];
                isAllValid = false;
            }

            if (userFromDatabaseByEmail != null)
            {
                ViewBag.EmailMessage = localizer["UserEmailExists"];
                isAllValid = false;
            }
            if (userFromDatabaseByNickname != null)
            {
                ViewBag.NicknameMessage = localizer["UserNicknameExists"];
                isAllValid = false;
            }
            if (isAllValid)
            {
                User user = new User(model.Nickname, model.Email)
                {
                    UserName = model.Email,
                    DateRegistration = DateTime.Now,
                    DateLastLogin = DateTime.Now
                };
                var result = await userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                    await signInManager.SignInAsync(user, false);
                    return RedirectToAction("Index", "Home");
                }                
            }
            return View();
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Login()
        {
            SetViewBag();
            LoginModel loginModel = new LoginModel()
            {
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            SetViewBag();
            User userFromDatabase = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            bool isAllValid = true;

            if (string.IsNullOrEmpty(model.Password))
            {
                ViewBag.PasswordMessage = localizer["FillInTheField"];
                isAllValid = false;
            }

            if (userFromDatabase == null)
            {
                ViewBag.EmailMessage = localizer["UserEmailNotExists"];
                isAllValid = false;
            }

            if(isAllValid && userFromDatabase.Status == "Заблокирован")
            {
                ViewBag.MessageAboutBlocked = localizer["YouAreBlocked"];
                isAllValid = false;
            }

            if (isAllValid)
            {
                userFromDatabase.DateLastLogin = DateTime.Now;

                await db.SaveChangesAsync();
                var result = await signInManager.PasswordSignInAsync(userFromDatabase.Email,model.Password,false, false);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ViewBag.PasswordMessage = localizer["PasswordEnteredIncorrectly"];
                }
            }
            LoginModel loginModel = new LoginModel()
            {
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(loginModel);
        }

        [AllowAnonymous]
        [HttpPost]
        public IActionResult ExternalLogins(string provider)
        {
            var redirectUrl = Url.Action("ExternalLoginCallback", "Account");

            var properties = signInManager.ConfigureExternalAuthenticationProperties(provider,redirectUrl);
            return new ChallengeResult(provider, properties);
        }

        [AllowAnonymous]
        public async Task<IActionResult> ExternalLoginCallback(string remoteError = null)
        {
            LoginModel loginModel = new LoginModel()
            {
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            if (remoteError != null)
            {
                ModelState.AddModelError(string.Empty, localizer["ProviderError"] + remoteError);

                return View("Login", loginModel);
            }

            var info = await signInManager.GetExternalLoginInfoAsync();

            if(info == null)
            {
                ModelState.AddModelError(string.Empty, localizer["FailedToLoadProviderInformation"]);
                return View("Login", loginModel);
            }

            var signInResult = await signInManager.ExternalLoginSignInAsync(info.LoginProvider, info.ProviderKey,
                isPersistent: false, bypassTwoFactor: false);

            if (signInResult.Succeeded)
            {
                return RedirectToAction("Index", "Home");
            }
            else
            {
                var email = info.Principal.FindFirstValue(ClaimTypes.Email);

                if(email != null)
                {
                    var user = await userManager.FindByEmailAsync(email);

                    if(user == null)
                    {
                        string userName = info.Principal.FindFirstValue(ClaimTypes.Name);
                        user = new User(userName, email)
                        {
                            DateRegistration = DateTime.Now,
                            DateLastLogin = DateTime.Now,
                            UserName = email
                        };

                        var result = await userManager.CreateAsync(user);
                        await userManager.AddLoginAsync(user, info);
                    }

                    if(user.Status == "Заблокирован")
                    {
                        ViewBag.MessageAboutBlocked = localizer["YouAreBlocked"];
                        return View("Login", loginModel);
                    }

                    await signInManager.SignInAsync(user, isPersistent: false);
                    
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.ErrorTitle = $"{info.LoginProvider} "+ localizer["NotProvideYourEmail"];
                ViewBag.ErrorMessage = localizer["ContactDeveloper"] + " dr.sasha2602@mail.ru";
                return View("Error");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }

        [NonAction]
        public bool SetViewBag()
        {
            ViewBag.Bg = "dark";
            ViewBag.Text = "light";
            if (ViewBag.AutorizeUser != null && ViewBag.AutorizeUser.Theme != "Dark")
            {
                ViewBag.Bg = "light";
                ViewBag.Text = "dark";
            }
            return true;
        }
    }
}
