using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services.FieldsServices;
using PersonalCollectionManagement.Services.ItemServices;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.CollectionServices
{
    public static class CollectionDeleter
    {
        public static async Task DeleteUserCollectionsAsync(string userId)
        {
            List<Collection> collections = CollectionSearcher.GetUserCollections(userId);

            for (int i = 0; i < collections.Count; i++)
            {
                await DeleteCollectionAsync(collections[i].Id);
            }
        }

        public static async Task DeleteCollectionAsync(int collectionId)
        {
            await ItemDeleter.DeleteCollectionItemsAsync(collectionId);
            await FieldsDeleter.DeleteCollectionFields(collectionId);
            Collection collection = CollectionSearcher.GetCollection(collectionId);
            Database.db.Remove(collection);
            await Database.db.SaveChangesAsync();
        }
    }
}
