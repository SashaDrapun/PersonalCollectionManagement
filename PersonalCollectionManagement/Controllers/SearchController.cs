using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class SearchController : Controller
    {
        public SearchController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        public async Task<IActionResult> Items(string act, string searchValue)
        {
            await SetViewBag();
            List<Item> items = ItemSearcher.GetAllItems();

            if (act == "search")
            {
                return View(Search(searchValue));
            }
            else
            {
                List<Tag> searchedTags = TagsSearcher.GetTags(searchValue);

                return View(ItemSearcher.GetItemsByTags(searchedTags));
            }
        }

        [NonAction]
        private List<Item> Search(string searchValue)
        {
            List<Item> items = Database.db.Items.ToList();
            List<Tag> tags = Database.db.Tags.ToList();
            List<Value> values = Database.db.Values.ToList();
            searchValue = "%" + searchValue + "%";

            Task<List<int>>[] tasks = new Task<List<int>>[4]
            {
                new Task<List<int>>(() =>
                {
                return items.Where(x => EF.Functions.Like(x.Name, searchValue)).Select(item => item.Id).ToList();
                }),
                new Task<List<int>>(() =>
                {
                return tags.Where(x => EF.Functions.Like(x.Value, searchValue)).Select(tag => tag.IdItem).ToList();
                }),
                new Task<List<int>>(() =>
                {
                    return values.Where(x => EF.Functions.Like(x.Information, searchValue)).Select(value => value.IdItem).ToList();
                }),

                new Task<List<int>>(() =>
                {
                    return Database.db.Comments.Where(x => EF.Functions.Like(x.Text, searchValue)).Select(comment => comment.ItemId).ToList();
                })
            };

            foreach (var t in tasks)
            {
                t.Start();
            }

            Task.WaitAll(tasks);

            List<int> allSearchedItemsId = tasks[0].Result.
                 Union(tasks[1].Result.
                 Union(tasks[2].Result.
                 Union(tasks[3].Result))).ToList();

            return items.Where(item => allSearchedItemsId.Contains(item.Id)).ToList();
        }

        [NonAction]
        public async Task<User> GetAutorizeUser()
        {
            return await Database.db.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
        }

        [NonAction]
        public async Task<bool> SetViewBag()
        {
            ViewBag.AutorizeUser = await GetAutorizeUser();
            ViewBag.Bg = HttpContext.Request.Cookies["Theme"];
            ViewBag.Text = ViewBag.Bg == "Dark" ? "Light" : "Dark";
            return true;
        }
    }
}
