using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.FieldsServices
{
    public static class FieldAdder
    {
        public static async Task AddCollectionFields(List<string> nameField, List<string> typeField, int idCollection)
        {
            if (nameField != null)
            {
                for (int i = 0; i < nameField.Count; i++)
                {
                    Database.db.Fields.Add(new Field(nameField[i], typeField[i], idCollection));
                }
            }

            await Database.db.SaveChangesAsync();
        }
    }
}
