

using JsonSupportExample.Model;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;

namespace JsonSupportExample.Data
{
    public class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Host=localhost;Port=5432;Database=JsonSupportEg;User ID=postgres;Password=sujan@321;");
        }
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }

    }
}
