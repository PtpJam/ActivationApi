using Microsoft.EntityFrameworkCore;

namespace ActivationApi.Models.Contex
{
    public class ActivationScannerContext : DbContext
    {

        public DbSet<Device> Devices { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("LocalDatabase");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
