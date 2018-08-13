using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace EE.Beers.Data
{
    public class BeersContextFactory : IDesignTimeDbContextFactory<BeersContext>
    {
        public BeersContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json").Build();
            var builder = new DbContextOptionsBuilder<BeersContext>();
            var connectionString = configuration.GetConnectionString("BeersDb");
            builder.UseSqlServer(connectionString);
            return new BeersContext(builder.Options);
        }
    }
}
