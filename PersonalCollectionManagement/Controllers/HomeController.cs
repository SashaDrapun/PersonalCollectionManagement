using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    public class HomeController : Controller
    {
        ApplicationContext db;

        public HomeController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> PersonalArea()
        {
            string nicknameAutorizeUser = HttpContext.Request.Cookies["NicknameAutorizeUser"];
            if (nicknameAutorizeUser == null)
            {
                return RedirectToAction("Index");
            }
            User ownerCollections = await db.Users.FirstOrDefaultAsync(u => u.Nickname == nicknameAutorizeUser);
            List<Collection> collections = db.Collections.Where(x => x.UserId == ownerCollections.Id).ToList();
            return View(collections);
        }

        [HttpPost]
        public async Task<IActionResult> CreateCollection(CollectionModel collectionModel)
        {
            List<Field> fields = new List<Field>();
            for (int i = 0; i < collectionModel.NameField.Count; i++)
            {
                fields.Add(new Field(collectionModel.NameField[i], collectionModel.TypeField[i]));
            }

            User ownerCollection = await db.Users.FirstOrDefaultAsync(u => u.Nickname == collectionModel.NicknameUser);

            Collection collection = new Collection(collectionModel.NameCollection, collectionModel.Description)
            {
                UserId = ownerCollection.Id,
                FormattedFields = fields
            };

            db.Collections.Add(collection);
            await db.SaveChangesAsync();
            return RedirectToAction("PersonalArea");
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCollection(int idCollection)
        {
            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == idCollection);
            db.Remove(collection);
            await db.SaveChangesAsync();
            return RedirectToAction("PersonalArea");
        }


        [HttpPost]
        public async Task<IActionResult> EditCollection(CollectionModel collectionModel)
        {
            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == collectionModel.IdCollection);

            collection.Name = collectionModel.NameCollection;
            collection.Description = collectionModel.Description;

            List<Field> fields = new List<Field>();
            for (int i = 0; i < collectionModel.NameField.Count; i++)
            {
                fields.Add(new Field(collectionModel.NameField[i], collectionModel.TypeField[i]));
            }

            collection.FormattedFields = fields;

            db.Collections.Update(collection);
            await db.SaveChangesAsync();
            return RedirectToAction("PersonalArea");
        }
    }
}
