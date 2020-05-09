using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public static class LikesHandler
    {
        public static List<Like> GetLikes(int idItem)
        {
            List<Like> likes = Database.db.Likes.Where(x => x.ItemId == idItem).ToList();

            return likes;
        }

        public static bool IsUserLike(User autorizeUser, List<Like> likes)
        {
            return autorizeUser == null ? false :
                likes.FirstOrDefault(x => x.UserId == autorizeUser.Id) == null ? false : true;
        }
    }
}
