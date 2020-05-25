using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.CommentServices
{
    public static class CommentAdder
    {
        public static async Task<Comment> AddCommentAsync(CommentModel commentModel)
        {
            User user = UsersSearcher.GetUserByNickname(commentModel.NicknameUser);

            Comment comment = new Comment
            {
                ItemId = commentModel.IdItem,
                Text = commentModel.Text,
                UserId = user.Id,
                DateTime = DateTime.Now,
            };

            Database.db.Comments.Add(comment);
            await Database.db.SaveChangesAsync();

            return comment;
        }
    }
}
