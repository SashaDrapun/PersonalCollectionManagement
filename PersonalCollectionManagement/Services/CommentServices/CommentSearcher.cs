using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.CommentServices
{
    public static class CommentSearcher
    {
        public static List<Comment> GetUserComments(string userId)
        {
            return Database.db.Comments.Where(comment => comment.UserId == userId).ToList();
        }

        public static List<Comment> GetItemComments(int itemId)
        {
            List<Comment> comments = Database.db.Comments.Where(x => x.ItemId == itemId).OrderByDescending(x => x.DateTime).ToList();

            for (int i = 0; i < comments.Count; i++)
            {
                User user = Database.db.Users.FirstOrDefault(u => u.Id == comments[i].UserId);
                comments[i].User = user;
            }

            return comments;
        }
    }
}
