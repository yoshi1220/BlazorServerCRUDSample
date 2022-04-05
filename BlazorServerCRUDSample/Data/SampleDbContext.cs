using BlazorServerCRUDSample.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorServerCRUDSample.Data
{
    public class SampleDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public SampleDbContext(DbContextOptions<SampleDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("Users");
            modelBuilder.Entity<User>()
                .Property(s => s.UserName)
                .IsRequired(false);
            modelBuilder.Entity<User>()
                .HasData(
                    new User
                    {
                        UserId = 1,
                        UserName = "山田太郎",
                        MailAddress = "yamada@mai.com",
                        BirthDay = new DateTime(2001, 1, 1)
                    },
                    new User
                    {
                        UserId = 2,
                        UserName = "小鳥遊咲",
                        MailAddress = "takanashi@mail.com",
                        BirthDay = new DateTime(2009, 12, 21)
                    },
                    new User
                    {
                        UserId = 3,
                        UserName = "山本杏里",
                        MailAddress = "anri@mail.com",
                        BirthDay = new DateTime(2004, 7, 11)
                    }
                );
        }
    }
}
