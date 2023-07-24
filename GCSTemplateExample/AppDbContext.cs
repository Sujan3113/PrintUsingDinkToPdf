using GCSTemplateExample.Model;
using Microsoft.EntityFrameworkCore;


namespace GCSTemplateExample
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options)
        {
        }

        #region

        public DbSet<Gcs> GcsTemplate { get; set; }


        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;Database=GcsTemplate;User Id=postgres;Password=sujan@321");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
