using Microsoft.EntityFrameworkCore;
using MySimit.Domain.Entities;

namespace MySimit.Infrastructure
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Country> Country { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Area> Area { get; set; }

    }
}
