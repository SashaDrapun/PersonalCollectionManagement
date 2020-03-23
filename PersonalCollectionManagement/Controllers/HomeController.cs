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

        public async Task<IActionResult> UserPage(int idUser)
        {   
            User ownerCollections = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);
            
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
            List<Item> items = db.Items.Where(x => x.CollectionId == idCollection).ToList();

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
        public async Task<IActionResult> Item(int id)
        {
            User autorizeUser = await GetAutorizeUser();
            ViewBag.AutorizeUser = autorizeUser;

            Item item = await db.Items.FirstOrDefaultAsync(x => x.Id == id);
            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == item.CollectionId);
            ViewBag.Comments = db.Comments.Where(x => x.ItemId == id).OrderByDescending(x=>x.DateTime).ToList();

            for (int i = 0; i < ViewBag.Comments.Count; i++)
            {
                int userId = ViewBag.Comments[i].UserId;
                User user = await db.Users.FirstOrDefaultAsync(u => u.Id == userId);
                ViewBag.Comments[i].User = user;
            }


            List<Like> likes = db.Likes.Where(x => x.ItemId == id).ToList();

            ViewBag.CountLikes = likes.Count;

            ViewBag.IsUserLike = autorizeUser == null ? false :
                likes.FirstOrDefault(x => x.UserId == autorizeUser.Id) == null ? false : true;

            item.Collection = collection;
            return View(item);
        }

        public async Task<IActionResult> Items(string searchText)
        {
            ViewBag.AutorizeUser = await GetAutorizeUser();
            searchText = "%"+searchText+"%";

            List<Item> items = db.Items.ToList();

            for (int i = 0; i < items.Count; i++)
            {
                Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == items[i].CollectionId);
                items[i].Collection = collection;
            }

            Task<List<int>>[] tasks = new Task<List<int>>[5]
            {
                new Task<List<int>>(() =>
                {
                return items.Where(x => EF.Functions.Like(x.Name, searchText)).Select(item => item.Id).ToList();
                }),
                new Task<List<int>>(() =>
                {
                return items.Where(x => EF.Functions.Like(x.Tegs, searchText)).Select(item => item.Id).ToList();
                }),
                new Task<List<int>>(() =>
                {
                    return items.Where(x => EF.Functions.Like(x.Values, searchText)).Select(item => item.Id).ToList();
                }),

                new Task<List<int>>(() =>
                {
                    return items.Where(x => EF.Functions.Like(x.Collection.Description, searchText)).Select(item => item.Id).ToList();
                }),

                new Task<List<int>>(() =>
                {
                    return db.Comments.Where(x => EF.Functions.Like(x.Text, searchText)).Select(comment => comment.ItemId).ToList();
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
                 Union(tasks[3].Result.
                 Union(tasks[4].Result)))).ToList();

            List<Item> allSearchedItems = items.Where(item => allSearchedItemsId.Contains(item.Id)).ToList();

            return View(allSearchedItems);
        }

        [NonAction]
        public async Task<User> GetAutorizeUser()
        {
            string nicknameAutorizeUser = HttpContext.Request.Cookies["NicknameAutorizeUser"];
            return await db.Users.FirstOrDefaultAsync(u => u.Nickname == nicknameAutorizeUser);
        }

        
    }
}
