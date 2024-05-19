using Microsoft.EntityFrameworkCore;
using Question2.Models;

namespace Question2.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Person> People { get; set; }
    }
}
