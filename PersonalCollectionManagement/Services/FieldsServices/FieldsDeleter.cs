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
            Database.db.Fields.RemoveRange(FieldsSearcher.GetFields(idCollection));
            await Database.db.SaveChangesAsync();
        }
    }
}
