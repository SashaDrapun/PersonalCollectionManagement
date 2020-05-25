using Microsoft.AspNetCore.Mvc;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    [Route("api/tegs")]
    public class TegsController : Controller
    {
        public TegsController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public IActionResult Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                List<string> tags = TagsSearcher.GetTagsValues();

                var sortedTegs = tags.Where(x => x.StartsWith(term)).Distinct().ToList();
                return Ok(sortedTegs);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
