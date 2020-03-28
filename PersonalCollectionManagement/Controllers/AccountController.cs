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
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    public class AccountController : Controller
    {
        ApplicationContext db;
        private SignInManager<User> signInManager;
        private UserManager<User> userManager;
        public AccountController(ApplicationContext applicationContext, SignInManager<User> signInManager, UserManager<User> 
            userManager)
        {
            db = applicationContext;
            this.signInManager = signInManager;
            this.userManager = userManager;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [ValidateAntiForgeryToken]
        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            User userFromDatabaseByEmail = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            User userFromDatabaseByNickname = await db.Users.FirstOrDefaultAsync(u => u.Nickname == model.Nickname);
            bool isAllValid = true;

            if (string.IsNullOrEmpty(model.Email))
            {
                ViewBag.EmailMessage = "Заполните поле";
                isAllValid = false;
            }

            if (string.IsNullOrEmpty(model.Nickname))
            {
                ViewBag.NicknameMessage = "Заполните поле";
                isAllValid = false;
            }

            if (string.IsNullOrEmpty(model.Password))
            {
                ViewBag.PasswordMessage = "Заполните поле";
                isAllValid = false;
            }

            if (string.IsNullOrEmpty(model.ConfirmPassword))
            {
                ViewBag.ConfirmPasswordMessage = "Заполните поле";
                isAllValid = false;
            } 

            if(model.Password != model.ConfirmPassword)
            {
                ViewBag.ConfirmPasswordMessage = "Пароли не совпадают";
                isAllValid = false;
            }

            if (userFromDatabaseByEmail != null)
            {
                ViewBag.EmailMessage = "Пользователь с такой почтой уже существует";
                isAllValid = false;
            }
            if (userFromDatabaseByNickname != null)
            {
                ViewBag.NicknameMessage = "Пользователь с таким никнеймом уже существует";
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
            LoginModel loginModel = new LoginModel()
            {
                ExternalLogins = (await signInManager.GetExternalAuthenticationSchemesAsync()).ToList()
            };
            return View(loginModel);
        }

        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            User userFromDatabase = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            bool isAllValid = true;

            if (userFromDatabase == null)
            {
                ViewBag.EmailMessage = "Пользователя с такой почтой не существует";
                isAllValid = false;
            }

            if( userFromDatabase.Status == "Заблокирован")
            {
                ViewBag.MessageAboutBlocked = "Вы заблокированы";
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
                    ViewBag.PasswordMessage = "Пароль введен неверно";
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
                ModelState.AddModelError(string.Empty, $"Ошибка провайдера{ remoteError }");

                return View("Login", loginModel);
            }

            var info = await signInManager.GetExternalLoginInfoAsync();

            if(info == null)
            {
                ModelState.AddModelError(string.Empty, $"Не удалось загрузить информацию провайдера");
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
                        ViewBag.MessageAboutBlocked = "Вы заблокированы";
                        return View("Login", loginModel);
                    }

                    await signInManager.SignInAsync(user, isPersistent: false);
                    
                    return RedirectToAction("Index", "Home");
                }

                ViewBag.ErrorTitle = $"{info.LoginProvider} не предоставил ваш email";
                ViewBag.ErrorMessage = $"Cвяжитесь с разработчиком по почте dr.sasha2602@mail.ru";
                return View("Error");
            }
        }
        public async Task<IActionResult> Logout()
        {
            await signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
    }
}
