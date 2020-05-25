using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.CommentServices
{
    public static class CommentDeleter
    {
        public static async Task DeleteUsersCommentsAsync(string userId)
        {
            Database.db.Comments.RemoveRange(CommentSearcher.GetUserComments(userId));
            await Database.db.SaveChangesAsync();
        }

        public static async Task DeleteItemCommentsAsync(int itemId)
        {
            Database.db.Comments.RemoveRange(CommentSearcher.GetItemComments(itemId));
            await Database.db.SaveChangesAsync();
        }
    }
}
