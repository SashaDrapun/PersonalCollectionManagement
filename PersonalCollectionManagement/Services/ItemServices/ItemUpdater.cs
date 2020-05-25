using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services.TagServices;
using PersonalCollectionManagement.Services.ValueServices;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.ItemServices
{
    public static class ItemUpdater
    {
        public static async Task UpdateItemAsync(ItemModel itemModel)
        {
            Item item = new Item
            {
                Id = itemModel.IdItem,
                CollectionId = itemModel.IdCollection,
                Name = itemModel.ItemName,
            };

            Database.db.Items.Update(item);
            await Database.db.SaveChangesAsync();

            await ValuesDeleter.DeleteItemValuesAsync(item.Id);
            await TagsDeleter.DeleteItemTagsAsync(item.Id);

            await ValuesAdder.AddItemValuesAsync(itemModel.ItemValue, item.Id);
            await TagsAdder.AddTagsAsync(itemModel.Tegs, item.Id);
        }
    }
}
