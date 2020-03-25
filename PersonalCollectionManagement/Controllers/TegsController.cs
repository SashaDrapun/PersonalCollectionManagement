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
                List<string> tegs = new List<string>();

                foreach(var item in db.Items)
                {
                    foreach (var teg in item.FormattedTegs)
                    {
                        tegs.Add(teg);
                    }
                }

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
