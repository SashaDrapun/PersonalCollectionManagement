using PersonalCollectionManagement.ViewModels;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using PersonalCollectionManagement.Services.FieldsServices;

namespace PersonalCollectionManagement.Services.CollectionServices
{
    public static class CollectionAdder
    {
        public static async Task AddCollection(CollectionModel collectionModel)
        {
            string path = await AppInviroment.CopyImage(CopyImageSettings.Collections, collectionModel.UploadedFile);

            User ownerCollection = UsersHandler.GetUser(collectionModel.IdUser);

            Collection collection = new Collection(collectionModel.NameCollection, collectionModel.Description, path)
            {
                UserId = ownerCollection.Id
            };

            Database.db.Collections.Add(collection);
            await Database.db.SaveChangesAsync();

            await FieldAdder.AddCollectionFields(collectionModel.NameField, collectionModel.TypeField, collection.Id);
        }
    }
}
