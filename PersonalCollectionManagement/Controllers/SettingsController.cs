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
        ApplicationContext db;

        public SettingsController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        public async Task<IActionResult> ChangeLanguage(string idUser,string language)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(language)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);

            user.Language = language;
            await db.SaveChangesAsync();
            return RedirectToAction("UserSettings", "Home");
        }

        public async Task<IActionResult> ChangeTheme(string idUser, string theme)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);

            user.Theme = theme;
            await db.SaveChangesAsync();
            return RedirectToAction("UserSettings", "Home");
        }
    }
}
