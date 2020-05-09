using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class UsersController : Controller
    {
        private ApplicationContext db;
        private readonly IStringLocalizer<UsersController> localizer;

        public UsersController(ApplicationContext applicationContext, IStringLocalizer<UsersController> localizer)
        {
            db = applicationContext;
            this.localizer = localizer;
        }

        public async Task<IActionResult> ChangeStatus(string idUser)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);

            user.Status = user.Status == "Разблокирован" ? localizer["Blocked"] : localizer["Unlocked"];
            await db.SaveChangesAsync();
            return RedirectToAction("Users", "Home");
        }

        public async Task<IActionResult> Delete(string idUser)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);

            List<Collection> collections = db.Collections.Where(x => x.UserId == user.Id).ToList();
            List<Comment> comments = db.Comments.Where(x => x.UserId == user.Id).ToList();
            List<Like> likes = db.Likes.Where(x => x.UserId == user.Id).ToList();

            foreach(var collection in collections)
            {
                db.Collections.Remove(collection);
            }

            foreach (var comment in comments)
            {
                db.Comments.Remove(comment);
            }

            foreach (var like in likes)
            {
                db.Likes.Remove(like);
            }


            db.Users.Remove(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Users", "Home");
        }

        public async Task<IActionResult> AppointAdministrator(string idUser)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);
            user.IsAdmin = true;
            await db.SaveChangesAsync();
            return RedirectToAction("Users", "Home");
        }
    }
}
