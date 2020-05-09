using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.ItemServices
{
    public static class ItemDeleter
    {
        public static async Task DeleteCollectionItemsAsync(int idCollection)
        {
            List<Item> items = ItemHandler.GetCollectionItems(idCollection);

            for (int i = 0; i < items.Count; i++)
            {
                await DeleteItemAsync(items[i].Id);
            }
        }

        public static async Task DeleteItemAsync(int idItem)
        {
            Item item = ItemHandler.GetItem(idItem);
            Database.db.Remove(item);
            await Database.db.SaveChangesAsync();
        }
    }
}
