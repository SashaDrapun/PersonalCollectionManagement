using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.ValueServices
{
    public static class ValuesSearcher
    {
        public static List<Value> GetItemValues(int itemId)
        {
            return Database.db.Values.Where(value => value.IdItem == itemId).ToList();
        }
    }
}
