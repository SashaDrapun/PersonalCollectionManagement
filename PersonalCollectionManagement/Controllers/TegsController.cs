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
        ApplicationContext db;

        public TegsController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        [Produces("application/json")]
        [HttpGet("search")]
        public IActionResult Search()
        {
            try
            {
                string term = HttpContext.Request.Query["term"].ToString();
                List<string> tegs = db.Tags.Select(x=>x.Value).ToList();

                var sortedTegs = tegs.Where(x => x.StartsWith(term)).Distinct().ToList();
                return Ok(sortedTegs);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}
