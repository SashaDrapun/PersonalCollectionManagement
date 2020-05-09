using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.FieldsServices
{
    public static class FieldsDeleter
    {
        public static async Task DeleteCollectionFields(int idCollection)
        {
            List<Field> fields = FieldsSearcher.GetFields(idCollection);

            for (int i = 0; i < fields.Count; i++)
            {
                Database.db.Fields.Remove(fields[i]);
            }

            await Database.db.SaveChangesAsync();
        }
    }
}
