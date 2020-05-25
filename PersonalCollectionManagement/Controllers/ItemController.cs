using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;
using PersonalCollectionManagement.Services.ItemServices;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public class ItemController : Controller
    {

        public ItemController(ApplicationContext applicationContext)
        {
            Database.SetDB(applicationContext);
        }

        #region Item
        [HttpPost]
        public async Task<IActionResult> CreateItem(ItemModel itemModel)
        {
            await ItemAdder.AddItemAsync(itemModel);

            return RedirectToAction("Collection", "Home", new { idCollection = itemModel.IdCollection});
        }

        public async Task<IActionResult> DeleteItem(int idItem)
        {
            Item item = ItemSearcher.GetItem(idItem);
            int collectionId = item.CollectionId;
            await ItemDeleter.DeleteItemAsync(idItem);
            return RedirectToAction("Collection", "Home", new { idCollection = collectionId});
        }

        [HttpPost]
        public async Task<IActionResult> EditItem(ItemModel itemModel)
        {
            await ItemUpdater.UpdateItemAsync(itemModel);

            return RedirectToAction("Collection", "Home", new { idCollection = itemModel.IdCollection });
        }

        #endregion
    }
}
