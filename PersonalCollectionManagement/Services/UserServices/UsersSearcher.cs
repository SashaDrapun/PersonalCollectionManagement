using System.Linq;
using PersonalCollectionManagement.Controllers;
using PersonalCollectionManagement.Models;

namespace PersonalCollectionManagement.Services
{
    public static class UsersSearcher
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

       public static User GetUserByNickname(string nickname)
       {
            return Database.db.Users.FirstOrDefault(user => user.Nickname == nickname);
       }

        public static User GetUserByEmail(string email)
        {
            return Database.db.Users.FirstOrDefault(user => user.Email == email);
        }
    }
}
