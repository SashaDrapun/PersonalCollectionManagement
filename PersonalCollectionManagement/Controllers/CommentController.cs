using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;
using PersonalCollectionManagement.Services.CommentServices;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    [Route("api/[controller]")]
    public class CommentController : ControllerBase
    {

        public CommentController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        [HttpPost]
        public async Task<ActionResult<Comment>> Post([FromBody]CommentModel commentModel)
        {
            return Ok(await CommentAdder.AddCommentAsync(commentModel));
        }
    }
}
