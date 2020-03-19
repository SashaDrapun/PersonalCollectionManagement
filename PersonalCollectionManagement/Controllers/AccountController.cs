using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    public class AccountController : Controller
    {
        ApplicationContext db;
        public AccountController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Register(RegisterModel model)
        {
            User userFromDatabaseByEmail = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            User userFromDatabaseByNickname = await db.Users.FirstOrDefaultAsync(u => u.Nickname == model.Nickname);
            bool isAllValid = true;
            
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
                User user = new User(model.Nickname, model.Email, model.Password)
                {
                    DateRegistration = DateTime.Now,
                    DateLastLogin = DateTime.Now
                };
                db.Users.Add(user);
                await db.SaveChangesAsync();
                HttpContext.Response.Cookies.Append("NicknameAutorizeUser", user.Nickname);
                return RedirectToAction("Index", "Home");
            }
            else
            {
                return View();
            }
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
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
            else if (userFromDatabase.Password != model.Password)
            {
                ViewBag.PasswordMessage =  "Пароль введен неверно";
                isAllValid = false;
            }
            if (isAllValid)
            {
                userFromDatabase.DateLastLogin = DateTime.Now;

                await db.SaveChangesAsync();
                HttpContext.Response.Cookies.Append("NicknameAutorizeUser", userFromDatabase.Nickname);
                return RedirectToAction("Index", "Home");
            }

            return View();
        }    
    }
}
