using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services
{
    public static class FieldsSearcher
    {
        public static List<Field> GetFields(int idCollection)
        {
            return Database.db.Fields.Where(field => field.IdCollection == idCollection).ToList();
        }
    }
}
