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

            ViewBag.Counts = new List<int>();

            for (int i = 0; i < collections.Count; i++)
            {
                ViewBag.Counts.Add(db.Items.Where(item=>item.CollectionId == collections[i].Id).Count());
            }
            return View(collections);
        }

        #region Collection
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
            Collection oldCollection = await db.Collections.FirstOrDefaultAsync(x => x.Id == collectionModel.IdCollection);

            oldCollection.Name = collectionModel.NameCollection;
            oldCollection.Description = collectionModel.Description;

            if(oldCollection.FormattedFields.Count != collectionModel.NameField.Count)
            {
                int countNewFields = collectionModel.TypeField.Count;
                int index = oldCollection.FormattedFields.Count;

                List<Field> fields = oldCollection.FormattedFields;
                for (int i = 0; i < countNewFields; i++)
                {
                    fields.Add(new Field(collectionModel.NameField[index],
                        collectionModel.TypeField[i]));
                    index++;
                }

                oldCollection.FormattedFields = fields;

                List<Item> items = db.Items.Where(x => x.CollectionId == oldCollection.Id).ToList();

                for (int j = 0; j < items.Count; j++)
                {
                    for (int i = 0; i < countNewFields; i++)
                    {
                        items[j].Values += ",";
                    }
                    db.Items.Update(items[j]);
                }
            }

            db.Collections.Update(oldCollection);
            await db.SaveChangesAsync();
            return RedirectToAction("PersonalArea");
        }

        public async Task<IActionResult> Collection(int idCollection)
        {
            List<Item> items = db.Items.Where(item => item.CollectionId == idCollection).ToList();

            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == idCollection);

            if (items.Count == 0)
            {
                Item item = new Item
                {
                    CollectionId = collection.Id,
                    Collection = collection,
                    Id = 0
                };

                items.Add(item);
            }
            else
            {
                items[0].Collection = collection;
            }
            return View(items);
        }
        #endregion

    }
}
