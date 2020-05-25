using PersonalCollectionManagement.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.TagServices
{
    public static class TagsDeleter
    {
        public static async Task DeleteItemTagsAsync(int itemId)
        {
            Database.db.Tags.RemoveRange(TagsSearcher.GetItemTags(itemId));
            await Database.db.SaveChangesAsync();
        }
    }
}
