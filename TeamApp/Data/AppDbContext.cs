using Microsoft.EntityFrameworkCore;
using TeamApp.Models;

namespace TeamApp.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<User>().HasData(
             new User
             {
                 Id = 1,
                 Username = "admin",
                 Password = "123"
             },
              new User
              {
                  Id = 2,
                  Username = "member",
                  Password = "123"
              },
              new User
              {
                  Id = 3,
                  Username = "client",
                  Password = "123"
              }
             );
        }

    }
}
