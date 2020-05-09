using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services.ItemServices;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.CollectionServices
{
    public static class CollectionDeleter
    {
        public static async Task DeleteCollectionAsync(int idCollection)
        {
            await ItemDeleter.DeleteCollectionItemsAsync(idCollection);
            Collection collection = CollectionSearcher.GetCollection(idCollection);
            Database.db.Remove(collection);
            await Database.db.SaveChangesAsync();
        }
    }
}
