using PersonalCollectionManagement.Models;
using PersonalCollectionManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.LikeServices
{
    public static class LikeAdder
    {
        public static async Task AddLikeAsync(LikeModel likeModel)
        {
            User user = UsersSearcher.GetUserByNickname(likeModel.NicknameUser);

            Like like = new Like
            {
                UserId = user.Id,
                ItemId = likeModel.IdItem
            };

            Database.db.Likes.Add(like);
            await Database.db.SaveChangesAsync();
        }
    }
}
