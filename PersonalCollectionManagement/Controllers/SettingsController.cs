using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class SettingsController : Controller
    {
        public SettingsController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        public IActionResult ChangeLanguage(string language)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            return RedirectToAction("UserSettings", "Home");
        }

        public IActionResult ChangeTheme(string theme)
        {
            HttpContext.Response.Cookies.Append("Theme", theme,
                 new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) });
            return RedirectToAction("UserSettings", "Home");
        }
    }
}
