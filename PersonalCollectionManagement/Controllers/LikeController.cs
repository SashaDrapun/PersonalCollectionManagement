using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;
using PersonalCollectionManagement.Services.LikeServices;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    [Route("api/[controller]")]
    public class LikeController : ControllerBase
    {
        public LikeController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        [HttpPost]
        public async Task<ActionResult<Like>> Post([FromBody]LikeModel likeModel)
        {
            await LikeAdder.AddLikeAsync(likeModel);
            return Ok();
        }

        [HttpDelete("{itemId}")]
        public async Task<ActionResult> Delete(int itemId)
        {
            User autorizeUser = await Database.db.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            await LikeDeleter.DeleteLike(itemId, autorizeUser);
            return Ok();
        }
    }
}
