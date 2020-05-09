using System.Linq;
using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;

namespace PersonalCollectionManagement.Services
{
    public static class UsersHandler
    {
       public static User GetUser(string idUser)
       {
           return Database.db.Users.FirstOrDefault(u => u.Id == idUser);
       }

       public static User GetUser(int idCollection)
       {
            Collection collection = CollectionSearcher.GetCollection(idCollection);

            return GetUser(collection.UserId);
       }
    }
}
