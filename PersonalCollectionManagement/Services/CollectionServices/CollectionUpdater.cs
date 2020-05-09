using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services.FieldsServices;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.CollectionServices
{
    public static class CollectionUpdater
    {
        public static async Task UpdateCollection(CollectionModel collectionModel)
        {
            Collection oldCollection = CollectionSearcher.GetCollection(collectionModel.IdCollection);
            User ownerUser = UsersHandler.GetUser(collectionModel.IdUser);

            oldCollection.Name = collectionModel.NameCollection;
            oldCollection.Description = collectionModel.Description;

            await FieldsDeleter.DeleteCollectionFields(oldCollection.Id);

            await FieldAdder.AddCollectionFields(collectionModel.NameField, collectionModel.TypeField, oldCollection.Id);

            Database.db.Collections.Update(oldCollection);

            await Database.db.SaveChangesAsync();
        }
    }
}
