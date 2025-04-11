using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Cartorio.Data
{
    public class AppDbContext : DbContext
    {
        protected readonly IConfiguration Configuration;

        public AppDbContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to postgres with connection string from app settings
            options.UseNpgsql(Configuration.GetConnectionString("DbConnection"));
        }

        public DbSet<Nascimento> Nascimentos { get; set; }
        public DbSet<Casamento> Casamentos { get; set; }
        public DbSet<Obito> Obitos { get; set; }

    }
}
