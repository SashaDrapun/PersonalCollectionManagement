using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Localization;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;
using PersonalCollectionManagement.Services.UserServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class UsersController : Controller
    {
        private readonly IStringLocalizer<UsersController> localizer;

        public UsersController(ApplicationContext applicationContext, IStringLocalizer<UsersController> localizer)
        {
            Database.SetDB(applicationContext);
            this.localizer = localizer;
        }

        public async Task<IActionResult> ChangeStatus(string idUser)
        {
            User user = UsersSearcher.GetUser(idUser);

            user.Status = user.Status == "Разблокирован" ? localizer["Blocked"] : localizer["Unlocked"];
            await UsersUpdater.UpdateUserAsync(user);
            return RedirectToAction("Users", "Home");
        }

        public async Task<IActionResult> Delete(string idUser)
        {
            await UsersDeleter.DeleteUserAsync(idUser);
            return RedirectToAction("Users", "Home");
        }

        public async Task<IActionResult> AppointAdministrator(string idUser)
        {
            User user = UsersSearcher.GetUser(idUser);
            user.IsAdmin = true;
            await UsersUpdater.UpdateUserAsync(user);
            return RedirectToAction("Users", "Home");
        }
    }
}
