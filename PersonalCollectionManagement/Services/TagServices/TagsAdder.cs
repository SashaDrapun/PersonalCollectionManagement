using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.TagServices
{
    public static class TagsAdder
    {
        public static async Task AddTagsAsync(string tags, int itemId)
        {
            var splitedTags = tags.Split('#');

            for (int i = 1; i < splitedTags.Length; i++)
            {
                Database.db.Tags.Add(new Tag(splitedTags[i], itemId));
            }

            await Database.db.SaveChangesAsync();
        }
    }
}
