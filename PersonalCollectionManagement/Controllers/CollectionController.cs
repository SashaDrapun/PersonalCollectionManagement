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
    public class CollectionController : Controller
    {
        ApplicationContext db;

        public CollectionController(ApplicationContext applicationContext)
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
                FormattedValues = itemModel.ItemValue,
                Tegs = itemModel.Tegs
            };

            db.Items.Add(item);
            await db.SaveChangesAsync();
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
                FormattedValues = itemModel.ItemValue
            };

            db.Items.Update(item);
            await db.SaveChangesAsync();
            return RedirectToAction("Collection", "Home", new { idCollection = item.CollectionId });
        }

        #endregion
    }
}
