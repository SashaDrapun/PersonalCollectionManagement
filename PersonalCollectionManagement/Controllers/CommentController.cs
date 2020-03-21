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
    public class CommentController : ControllerBase
    {
        ApplicationContext db;

        public CommentController(ApplicationContext context)
        {
            db = context;
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> Post([FromBody]CommentModel commentModel)
        {
            User user = await db.Users.FirstOrDefaultAsync(x => x.Nickname == commentModel.NicknameUser);

            Comment comment = new Comment
            {
                ItemId = commentModel.IdItem,
                Text = commentModel.Text,
                UserId = user.Id,
                DateTime = DateTime.Now,
                User = user
            };

            db.Comments.Add(comment);
            await db.SaveChangesAsync();
            return Ok(comment);
        }
    }
}
