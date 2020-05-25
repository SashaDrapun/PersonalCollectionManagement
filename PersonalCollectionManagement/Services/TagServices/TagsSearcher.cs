using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public static class TagsSearcher
    {
        public static List<Tag> GetTags(string searchValue)
        {
            return Database.db.Tags.Where(x => x.Value == searchValue).ToList();
        }

        public static List<string> GetTagsValues()
        {
            return Database.db.Tags.Select(x => x.Value).Distinct().ToList();
        }

        public static List<Tag> GetItemTags(int itemId)
        {
            return Database.db.Tags.Where(tag => tag.IdItem == itemId).ToList();
        }
    }
}
