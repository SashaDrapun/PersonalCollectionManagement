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
    [Route("api/[controller]")]
    public class AccountController : ControllerBase
    {
        ApplicationContext db;
        public AccountController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> Get()
        {
            return await db.Users.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<User>> Post([FromBody]RegisterModel model)
        {
            User userFromDatabaseByEmail = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);
            User userFromDatabaseByNickname = await db.Users.FirstOrDefaultAsync(u => u.Nickname == model.Nickname);

            if (userFromDatabaseByEmail != null)
            {
                ModelState.AddModelError("email", "Пользователь с такой почтой уже существует");
                return BadRequest(ModelState);
            }
            if (userFromDatabaseByNickname != null)
            {
                ModelState.AddModelError("nickname", "Пользователь с таким никнеймом уже существует");
                return BadRequest(ModelState);
            }
            User user = new User(model.Nickname, model.Email, model.Password)
            {
                DateRegistration = DateTime.Now,
                DateLastLogin = DateTime.Now
            };
            db.Users.Add(user);
            await db.SaveChangesAsync();
            HttpContext.Response.Cookies.Append("NicknameAutorizeUser", user.Nickname);
            return Ok();
        }

        [HttpPut]
        public async Task<ActionResult<User>> Put([FromBody]LoginModel model)
        {
            User userFromDatabase = await db.Users.FirstOrDefaultAsync(u => u.Email == model.Email);

            if(userFromDatabase == null)
            {
                ModelState.AddModelError("email", "Пользователя с такой почтой не существует");
                return BadRequest(ModelState);
            }
            if(userFromDatabase.Password != model.Password)
            {
                ModelState.AddModelError("password", "Пароль введен неверно");
                return BadRequest(ModelState);
            }
            HttpContext.Response.Cookies.Append("NicknameAutorizeUser", userFromDatabase.Nickname);
            return Ok();
        }
    }
}
