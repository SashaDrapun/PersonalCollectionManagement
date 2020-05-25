using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services.CommentServices;
using PersonalCollectionManagement.Services.LikeServices;
using PersonalCollectionManagement.Services.TagServices;
using PersonalCollectionManagement.Services.ValueServices;
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
            List<Item> items = ItemSearcher.GetCollectionItems(idCollection);

            for (int i = 0; i < items.Count; i++)
            {
                await DeleteItemAsync(items[i].Id);
            }
        }

        public static async Task DeleteItemAsync(int idItem)
        {
            Item item = ItemSearcher.GetItem(idItem);
            await LikeDeleter.DeleteItemLikesAsync(idItem);
            await CommentDeleter.DeleteItemCommentsAsync(idItem);
            await TagsDeleter.DeleteItemTagsAsync(idItem);
            await ValuesDeleter.DeleteItemValuesAsync(idItem);

            Database.db.Remove(item);
            await Database.db.SaveChangesAsync();
        }
    }
}
