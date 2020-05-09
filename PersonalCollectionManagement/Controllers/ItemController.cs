using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class ItemController : Controller
    {
        ApplicationContext db;

        public ItemController(ApplicationContext applicationContext)
        {
            db = applicationContext;
        }

        #region Item
        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemModel itemModel)
        {
            Item item = new Item
            {
                CollectionId = itemModel.IdCollection,
                Name = itemModel.ItemName,
            };

            db.Items.Add(item);
            await db.SaveChangesAsync();

            for (int i = 0; i < itemModel.ItemValue.Count; i++)
            {
                db.Values.Add(new Value(itemModel.ItemValue[i], item.Id));
            }

            await db.SaveChangesAsync();

            var splitedTags = itemModel.Tegs.Split('#');

            for (int i = 1; i < splitedTags.Length; i++)
            {
                db.Tags.Add(new Tag(splitedTags[i], item.Id));
            }

            return RedirectToAction("Collection", "Home", new { idCollection = item.CollectionId});
        }

        public async Task<IActionResult> DeleteItem(int idItem)
        {
            Item item = await db.Items.FirstOrDefaultAsync(item => item.Id == idItem);

            int collectionId = item.CollectionId;
            db.Items.Remove(item);
            await db.SaveChangesAsync();
            return RedirectToAction("Collection", "Home", new { idCollection = collectionId});
        }

        [HttpPost]
        public async Task<IActionResult> EditItem(ItemModel itemModel)
        {
            Item item = new Item
            {
                Id = itemModel.IdItem,
                CollectionId = itemModel.IdCollection,
                Name = itemModel.ItemName,
            };

            var oldValues = db.Values.Where(x => x.IdItem == item.Id).ToList();

            db.Values.RemoveRange(oldValues);

            await db.SaveChangesAsync();

            var oldTags = db.Tags.Where(x => x.IdItem == item.Id).ToList();

            db.Tags.RemoveRange(oldTags);

            await db.SaveChangesAsync();

            db.Items.Update(item);
            await db.SaveChangesAsync();

            for (int i = 0; i < itemModel.ItemValue.Count; i++)
            {
                db.Values.Add(new Value(itemModel.ItemValue[i], item.Id));
            }

            await db.SaveChangesAsync();

            var splitedTags = itemModel.Tegs.Split('#');

            for (int i = 1; i < splitedTags.Length; i++)
            {
                db.Tags.Add(new Tag(splitedTags[i], item.Id));
            }

            return RedirectToAction("Collection", "Home", new { idCollection = item.CollectionId });
        }

        #endregion
    }
}
