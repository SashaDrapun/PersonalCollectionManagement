using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;

namespace PersonalCollectionManagement.Controllers
{
    public class HomeController : Controller
    {
        public HomeController(ApplicationContext applicationContext, IWebHostEnvironment appEnvironment)
        {
            Database.SetDB(applicationContext);
            AppInviroment.SetAppEnvironment(appEnvironment);
        }

        public async Task<IActionResult> Index()
        {
            await SetViewBag();

            ViewBag.LastAddedItems = ItemHandler.GetLastAddedItems(5);

            ViewBag.CollectionsWithMostOfItems = CollectionSearcher.GetCollectionsWithMostOfItems(5);

            ViewBag.AllTegs = TagsHandler.GetTagsValues();

            return View();
        }

        public async Task<IActionResult> UserPage(string idUser)
        {
            await SetViewBag();

            ViewBag.OwnerCollections = UsersHandler.GetUser(idUser);

            return View(CollectionSearcher.GetUserCollections(idUser));
        }

        public async Task<IActionResult> Collections()
        {
            await SetViewBag();
            return View(Database.db.Collections.ToList());
        }

        public async Task<IActionResult> Collection(int idCollection)
        {
            await SetViewBag();

            ViewBag.Collection = CollectionSearcher.GetCollection(idCollection);

            return View(ItemHandler.GetCollectionItems(idCollection));
        }

        public async Task<IActionResult> Users()
        {
            await SetViewBag();
            return View(Database.db.Users.ToList());
        }
        public async Task<IActionResult> Item(int id)
        {
            await SetViewBag();

            User autorizeUser = await GetAutorizeUser();
            Item item = ItemHandler.GetItem(id);
            ViewBag.Collection = CollectionSearcher.GetCollection(item.CollectionId);
            ViewBag.Comments = CommentsHandler.GetComments(item.Id);

            List<Like> likes = LikesHandler.GetLikes(item.Id);
            ViewBag.CountLikes = likes.Count;
            ViewBag.IsUserLike = LikesHandler.IsUserLike(autorizeUser, likes);

            return View(item);
        }

        public async Task<IActionResult> UserSettings()
        {
            ViewBag.Language = CultureHandler.GetCulture();
            await SetViewBag();
            return View();
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
            ViewBag.Bg = HttpContext.Request.Cookies["Theme"] == null ? "dark" : HttpContext.Request.Cookies["Theme"];
            ViewBag.Text = ViewBag.Bg == "dark" ? "light" : "dark";
            return true;
        }
    }
}
