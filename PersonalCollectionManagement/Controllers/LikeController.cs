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
    public class LikeController : ControllerBase
    {
        ApplicationContext db;

        public LikeController(ApplicationContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<ActionResult<Like>> Post([FromBody]LikeModel likeModel)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.Nickname == likeModel.NicknameUser);

            Like like = new Like
            {
                UserId = user.Id,
                ItemId = likeModel.IdItem
            };

            db.Likes.Add(like);
            await db.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{userNickname}")]
        public async Task<ActionResult> Delete(string userNickname)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.Nickname == userNickname);
            Like like = db.Likes.FirstOrDefault(x => x.UserId == user.Id);
            db.Likes.Remove(like);
            await db.SaveChangesAsync();
            return Ok();
        }
    }
}
