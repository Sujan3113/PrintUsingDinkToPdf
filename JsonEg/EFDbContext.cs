

using JsonEg.Model;
using Microsoft.EntityFrameworkCore;

namespace JsonEg
{
    public class EFDbContext : DbContext
    {
        public EFDbContext(DbContextOptions options) : base(options)
        {
        }

        #region

        public DbSet<Employee> Employee { get; set; }


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=JsonEg;User Id=postgres;Password=sujan@321");

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().OwnsOne(
                employee => employee.ContactDetails, ownedNavigationBuilder =>
                {
                    //ownedNavigationBuilder.ToJson();
                    ownedNavigationBuilder.OwnsOne(_ => _.Contacts);
                    ownedNavigationBuilder.OwnsMany(_ => _.Addresses);
                });

            base.OnModelCreating(modelBuilder);
        }
    }
}
