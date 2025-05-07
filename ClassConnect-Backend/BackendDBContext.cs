using ClassConnect_Backend.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassConnect_Backend
{
    public class BackendDBContext : DbContext
    {
        public BackendDBContext(DbContextOptions<BackendDBContext> options) : base (options)
        {
        }


        public DbSet<User> Users { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }

    }
}
