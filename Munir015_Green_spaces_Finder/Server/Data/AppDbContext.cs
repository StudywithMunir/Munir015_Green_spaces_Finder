using Microsoft.EntityFrameworkCore;
using Munir015_Green_spaces_Finder.Shared;
using System.Security.Claims;

namespace Munir015_Green_spaces_Finder.Server.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<GreenSpace> GreenSpaces { get; set; }
        public DbSet<SearchHistory> SearchHistories { get; set; }
        public DbSet<UserFavorite> UserFavorites { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Admin> Admins { get; set; }


        //quiz models
        public DbSet<Student> Students { get; set; }
        public DbSet<Faculty> Faculties { get; set; }
        public DbSet<Course> Courses { get; set; }


    }
}
