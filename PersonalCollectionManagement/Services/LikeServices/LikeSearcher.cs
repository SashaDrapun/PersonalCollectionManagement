using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.LikeServices
{
    public static class LikeSearcher
    {
        public static List<Like> GetUserLikes(string userId)
        {
            return Database.db.Likes.Where(like => like.UserId == userId).ToList();
        } 

        public static List<Like> GetItemLikes(int itemId)
        {
            return Database.db.Likes.Where(like => like.ItemId == itemId).ToList();
        }

        public static Like GetLike(string userId, int itemId)
        {
            return Database.db.Likes.Where(x => x.UserId == userId && x.ItemId == itemId).FirstOrDefault();
        }

        public static bool IsUserLike(User autorizeUser, List<Like> likes)
        {
            return autorizeUser == null ? false :
                likes.FirstOrDefault(x => x.UserId == autorizeUser.Id) == null ? false : true;
        }
    }
}
