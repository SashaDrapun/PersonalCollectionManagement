using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;

namespace PersonalCollectionManagement.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;

        public HomeController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        public async Task<IActionResult> Index()
        {
            await SetViewBag();
            ViewBag.LastAddedItems = db.Items.OrderByDescending(x => x.Collection).Take(5).ToList();

            List<Collection> collections = db.Collections.ToList();

            for (int i = 0; i < collections.Count; i++)
            {
                collections[i].CountItems = db.Items.
                    Where(item => item.CollectionId == collections[i].Id).
                    Count();
            }

            ViewBag.CollectionsWithMostOfItems = collections.OrderByDescending(x => x.CountItems).Take(5);

            List<string> allTegs = new List<string>();

            if (db.Items.Count() != 0)
            {
                foreach (var item in db.Items)
                {
                    foreach (var teg in item.FormattedTegs)
                    {
                        allTegs.Add(teg);
                    }
                }
            }

            ViewBag.AllTegs = allTegs.Distinct().ToList();

            return View();
        }

        [HttpPost]
        public IActionResult UploadFiles(IEnumerable<IFormFile> file)
        {
            foreach(var oneFile in file)
            {
                string filePath = Guid.NewGuid() + Path.GetExtension(oneFile.FileName);
                
            }
            return Json("Good");
        }

        public async Task<IActionResult> UserPage(string idUser)
        {
            await SetViewBag();

            User ownerCollections = await db.Users.FirstOrDefaultAsync(u => u.Id == idUser);
            
            List<Collection> collections = db.Collections.Where(x => x.UserId == ownerCollections.Id).ToList();
            ViewBag.OwnerCollections = ownerCollections;
            return View(collections);
        }

        public async Task<IActionResult> Collections()
        {
            await SetViewBag();
            return View(db.Collections.ToList());
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
            return RedirectToAction("UserPage", "Home", new { idUser = ownerCollection.Id });
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCollection(int idCollection)
        {
            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == idCollection);
            User ownerUser = await db.Users.FirstOrDefaultAsync(u => u.Id == collection.UserId);
            string ownerId = ownerUser.Id;
            db.Remove(collection);
            await db.SaveChangesAsync();
            return RedirectToAction("UserPage", "Home", new { idUser = ownerId });
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
            string ownerId = ownerUser.Id;
            db.Collections.Update(oldCollection);
            await db.SaveChangesAsync();
            return RedirectToAction("UserPage", "Home", new { idUser = ownerId });
        }

        public async Task<IActionResult> Collection(int idCollection)
        {
            await SetViewBag();
            
            List<Item> items = db.Items.Where(x => x.CollectionId == idCollection).ToList();

            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == idCollection);

            ViewBag.CollectionDescription = Markdown.ParseHtmlString(collection.Description);

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

            ViewBag.OwnerCollection = await db.Users.FirstOrDefaultAsync(x => x.Id == collection.UserId);
            return View(items);
        }
        #endregion

        public async Task<IActionResult> UsersAsync()
        {
            await SetViewBag();
            return View(db.Users.ToList());
        }
        public async Task<IActionResult> Item(int id)
        {
            await SetViewBag();
            User autorizeUser = await GetAutorizeUser();
           
            Item item = await db.Items.FirstOrDefaultAsync(x => x.Id == id);
            Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == item.CollectionId);
            ViewBag.Comments = db.Comments.Where(x => x.ItemId == id).OrderByDescending(x=>x.DateTime).ToList();

            for (int i = 0; i < ViewBag.Comments.Count; i++)
            {
                string userId = ViewBag.Comments[i].UserId;
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

        public async Task<IActionResult> Items(string act, string searchValue)
        {
            await SetViewBag();
            List<Item> items = db.Items.ToList();

            for (int i = 0; i < items.Count; i++)
            {
                Collection collection = await db.Collections.FirstOrDefaultAsync(x => x.Id == items[i].CollectionId);
                items[i].Collection = collection;
            }

            if (act == "search")
            {                
                return View(Search(searchValue));
            }
            else
            {
                List<Item> allSearchedItems = items.Where(item => item.FormattedTegs.Contains(searchValue)).ToList();
                return View(allSearchedItems);
            }
        }

        public async Task<IActionResult> UserSettings()
        {
            ViewBag.Language = GetCulture();
            await SetViewBag();
            return View();
        }

        [NonAction]
        public List<Item> Search(string searchValue)
        {
            List<Item> items = db.Items.ToList();
            searchValue = "%" + searchValue + "%";

            Task<List<int>>[] tasks = new Task<List<int>>[5]
            {
                new Task<List<int>>(() =>
                {
                return items.Where(x => EF.Functions.Like(x.Name, searchValue)).Select(item => item.Id).ToList();
                }),
                new Task<List<int>>(() =>
                {
                return items.Where(x => EF.Functions.Like(x.Tegs, searchValue)).Select(item => item.Id).ToList();
                }),
                new Task<List<int>>(() =>
                {
                    return items.Where(x => EF.Functions.Like(x.Values, searchValue)).Select(item => item.Id).ToList();
                }),

                new Task<List<int>>(() =>
                {
                    return items.Where(x => EF.Functions.Like(x.Collection.Description, searchValue)).Select(item => item.Id).ToList();
                }),

                new Task<List<int>>(() =>
                {
                    return db.Comments.Where(x => EF.Functions.Like(x.Text, searchValue)).Select(comment => comment.ItemId).ToList();
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

            return items.Where(item => allSearchedItemsId.Contains(item.Id)).ToList();
        }

        [NonAction]
        public async Task<User> GetAutorizeUser()
        {
            string emailAutorizeUser = User.Identity.Name;
            return await db.Users.FirstOrDefaultAsync(u => u.Email == emailAutorizeUser);
        }

        [NonAction]
        public string GetCulture(string code = "")
        {
            if (!String.IsNullOrEmpty(code))
            {
                CultureInfo.CurrentCulture = new CultureInfo(code);
                CultureInfo.CurrentUICulture = new CultureInfo(code);
            }
            return CultureInfo.CurrentCulture.Name;
        }

        [NonAction]
        public async Task<bool> SetViewBag()
        {
            ViewBag.AutorizeUser = await GetAutorizeUser();
            string value = HttpContext.Request.Cookies["Theme"];
            
            ViewBag.Bg = "dark";
            ViewBag.Text = "light";
            if (value != "dark")
            {
                ViewBag.Bg = "light";
                ViewBag.Text = "dark";
            }
            return true;
        }

        
    }
}
