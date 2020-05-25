using PersonalCollectionManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonalCollectionManagement.Services.UserServices
{
    public static class UsersUpdater
    {
        public static async Task UpdateUserAsync(User user)
        {
            Database.db.Users.Update(user);
            await Database.db.SaveChangesAsync();
        }
    }
}
