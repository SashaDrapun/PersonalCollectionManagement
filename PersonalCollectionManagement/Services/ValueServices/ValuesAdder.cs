using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.ValueServices
{
    public static class ValuesAdder
    {
        public static async Task AddItemValuesAsync(List<string> values, int idItem)
        {
            for (int i = 0; i < values.Count; i++)
            {
                Database.db.Values.Add(new Value(values[i], idItem));
            }

            await Database.db.SaveChangesAsync();
        }
    }
}
