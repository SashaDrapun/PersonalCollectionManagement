using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.ValueServices
{
    public static class ValuesDeleter
    {
        public static async Task DeleteItemValuesAsync(int idItem)
        {
            Database.db.Values.RemoveRange(ValuesSearcher.GetItemValues(idItem));
            await Database.db.SaveChangesAsync();
        }
    }
}
