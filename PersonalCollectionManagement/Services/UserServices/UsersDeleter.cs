using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.Services.CollectionServices;
using PersonalCollectionManagement.Services.CommentServices;
using PersonalCollectionManagement.Services.LikeServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.UserServices
{
    public static class UsersDeleter
    {
        public static async Task DeleteUserAsync(string userId)
        {
            await CommentDeleter.DeleteUsersCommentsAsync(userId);
            await LikeDeleter.DeleteUserLikesAsync(userId);
            await CollectionDeleter.DeleteUserCollectionsAsync(userId);

            User user = UsersSearcher.GetUser(userId);
            Database.db.Users.Remove(user);
            await Database.db.SaveChangesAsync();
        }
    }
}
