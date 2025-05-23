using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using escola.Data;
using System.IO;

namespace escola
{
    public class EscolaContextFactory : IDesignTimeDbContextFactory<escolaContext>
    {
        public escolaContext CreateDbContext(string[] args)
        {
            // Lê o appsettings.json
            var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = config.GetConnectionString("escolaContext");

            var optionsBuilder = new DbContextOptionsBuilder<escolaContext>();
            optionsBuilder.UseSqlServer(connectionString);

            return new escolaContext(optionsBuilder.Options);
        }
    }
}
