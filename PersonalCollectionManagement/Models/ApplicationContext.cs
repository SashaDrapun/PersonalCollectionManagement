using Microsoft.EntityFrameworkCore;

namespace PersonalCollectionManagement.Models
{
    public class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Settings> Settings { get; set; }

        public DbSet<Collection> Collections { get; set; }

        public DbSet<Item> Items { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Like> Likes { get; set; }
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
            Database.EnsureCreated();   // создаем базу данных при первом обращении
        }
    }
}