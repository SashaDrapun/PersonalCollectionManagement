using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public static class CollectionSearcher
    {
        private static Collection SetCollection(Collection collection)
        {
            collection.Fields = FieldsSearcher.GetFields(collection.Id);

            collection.OwnerCollection = Database.db.Users.FirstOrDefault(x => x.Id == collection.UserId);

            collection.CountItems = Database.db.Items.
                    Where(item => item.CollectionId == collection.Id).
                    Count();

            return collection;
        }

        private static List<Collection> SetCollections(List<Collection> collections)
        {
            for (int i = 0; i < collections.Count; i++)
            {
                collections[i] = SetCollection(collections[i]);
            }

            return collections;
        }

        
        public static List<Collection> GetAllCollections()
        {
            return SetCollections(Database.db.Collections.ToList());
        }
        public static List<Collection> GetCollectionsWithMostOfItems(int count)
        {
            List<Collection> collections = GetAllCollections();

            return collections.OrderByDescending(x => x.CountItems).Take(count).ToList();
        }

 
        public static List<Collection> GetUserCollections(string idUser)
        {
            return SetCollections(Database.db.Collections.Where(x => x.UserId == idUser).ToList());
        }

        public static Collection GetCollection(int idCollection)
        {
            Collection collection = Database.db.Collections.FirstOrDefault(collection => collection.Id == idCollection);

            return SetCollection(collection);
        }

        
    }
}
