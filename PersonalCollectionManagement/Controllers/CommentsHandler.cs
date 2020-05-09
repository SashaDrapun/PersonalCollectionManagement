using Microsoft.EntityFrameworkCore;
using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Controllers
{
    public static class CommentsHandler
    {
        public static List<Comment> GetComments(int idItem)
        {
            List<Comment> comments = Database.db.Comments.Where(x => x.ItemId == idItem).OrderByDescending(x => x.DateTime).ToList();

            for (int i = 0; i < comments.Count; i++)
            {
                User user = Database.db.Users.FirstOrDefault(u => u.Id == comments[i].UserId);
                comments[i].User = user;
            }

            return comments;
        }
    }
}
