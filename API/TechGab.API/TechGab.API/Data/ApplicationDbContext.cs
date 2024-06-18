using Microsoft.EntityFrameworkCore;
using TechGab.API.Models.Domain;

namespace TechGab.API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Category>Categories { get; set; }
    }
}
