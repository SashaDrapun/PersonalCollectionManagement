using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class UsersController : Controller
    {
        ApplicationContext db;

        public UsersController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        public async Task<IActionResult> ChangeStatus(int idUser)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);

            user.Status = user.Status == "Разблокирован" ? "Заблокирован" : "Разблокирован";
            await db.SaveChangesAsync();
            return RedirectToAction("Users", "Home");
        }

        public async Task<IActionResult> Delete(int idUser)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);
            db.Users.Remove(user);
            await db.SaveChangesAsync();
            return RedirectToAction("Users", "Home");
        }

        public async Task<IActionResult> AppointAdministrator(int idUser)
        {
            User user = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);
            user.IsAdmin = true;
            await db.SaveChangesAsync();
            return RedirectToAction("Users", "Home");
        }
    }
}
