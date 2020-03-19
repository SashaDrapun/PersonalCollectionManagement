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

        public async Task<IActionResult> Index()
        {
            ViewBag.AutorizeUser = await GetAutorizeUser();
            return View();
        }

        public async Task<IActionResult> UserPage(string nicknameUser)
        {   
            User ownerCollections = await db.Users.FirstOrDefaultAsync(u => u.Nickname == nicknameUser);
            
            List<Collection> collections = db.Collections.Where(x => x.UserId == ownerCollections.Id).ToList();

            ViewBag.AutorizeUser = await GetAutorizeUser();
            ViewBag.OwnerCollections = ownerCollections;

            return View(collections);
        }

        #region Collection
        [HttpPost]
        public async Task<IActionResult> CreateCollection(CollectionModel collectionModel)
        {
            List<Field> fields = new List<Field>();

            if (collectionModel.NameField != null)
            {
                for (int i = 0; i < collectionModel.NameField.Count; i++)
                {
                    fields.Add(new Field(collectionModel.NameField[i], collectionModel.TypeField[i]));
                }
            }
           
            User ownerCollection = await db.Users.FirstOrDefaultAsync(u => u.Nickname == collectionModel.NicknameUser);

            Collection collection = new Collection(collectionModel.NameCollection, collectionModel.Description)
            {
                User = ownerCollection,
                UserId = ownerCollection.Id,
                FormattedFields = fields
            };

            db.Collections.Add(collection);
            await db.SaveChangesAsync();
            return RedirectToAction("UserPage", "Home", new { nicknameUser = ownerCollection.Nickname });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCollection(int idCollection)
        {
            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == idCollection);
            User ownerUser = await db.Users.FirstOrDefaultAsync(u => u.Id == collection.UserId);
            string ownerNickname = ownerUser.Nickname;
            db.Remove(collection);
            await db.SaveChangesAsync();
            return RedirectToAction("UserPage", "Home", new { nicknameUser = ownerNickname });
        }


        [HttpPost]
        public async Task<IActionResult> EditCollection(CollectionModel collectionModel)
        {
            Collection oldCollection = await db.Collections.FirstOrDefaultAsync(x => x.Id == collectionModel.IdCollection);

            oldCollection.Name = collectionModel.NameCollection;
            oldCollection.Description = collectionModel.Description;

            if(collectionModel.NameField != null)
            {
                if (oldCollection.FormattedFields.Count != collectionModel.NameField.Count)
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
                else
                {
                    List<Field> fields = new List<Field>();
                    for (int i = 0; i < oldCollection.FormattedFields.Count; i++)
                    {
                        fields.Add(new Field(collectionModel.NameField[i], oldCollection.FormattedFields[i].Type));
                    }

                    oldCollection.FormattedFields = fields;
                }
            }
           

            User ownerUser = await db.Users.FirstOrDefaultAsync(u => u.Id == oldCollection.UserId);
            string ownerNickname = ownerUser.Nickname;
            db.Collections.Update(oldCollection);
            await db.SaveChangesAsync();
            return RedirectToAction("UserPage", "Home", new { nicknameUser = ownerNickname });
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
            ViewBag.AutorizeUser = await GetAutorizeUser();
            return View(items);
        }
        #endregion

        public async Task<IActionResult> Users()
        {
            ViewBag.AutorizeUser = await GetAutorizeUser();
            List<User> users = db.Users.ToList();

            return View(users);
        }

        [NonAction]
        public async Task<User> GetAutorizeUser()
        {
            string nicknameAutorizeUser = HttpContext.Request.Cookies["NicknameAutorizeUser"];
            return await db.Users.FirstOrDefaultAsync(u => u.Nickname == nicknameAutorizeUser);
           
        }
    }
}
