using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineStore.Data.EF
{
    public class WineStoreDbContectFactory : IDesignTimeDbContextFactory<WineStoreDbContext>
    {
        public WineStoreDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("WineStoreDatabase");

            var optionsBuilder = new DbContextOptionsBuilder<WineStoreDbContext>();
            optionsBuilder.UseSqlServer(connectionString);
            return new WineStoreDbContext(optionsBuilder.Options);
        }
    }
}
