using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.LikeServices
{
    public static class LikeDeleter
    {
        public static async Task DeleteUserLikesAsync(string userId)
        {
            Database.db.Likes.RemoveRange(LikeSearcher.GetUserLikes(userId));
            await Database.db.SaveChangesAsync();
        }

        public static async Task DeleteItemLikesAsync(int itemId)
        {
            Database.db.Likes.RemoveRange(LikeSearcher.GetItemLikes(itemId));
            await Database.db.SaveChangesAsync();
        }

        public static async Task DeleteLike(int itemId, User autorizeUser)
        {
            Like like = LikeSearcher.GetLike(autorizeUser.Id, itemId);
            Database.db.Likes.Remove(like);
            await Database.db.SaveChangesAsync();
        }
    }
}
