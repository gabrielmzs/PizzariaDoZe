using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.Compartilhado {
    internal class PizzariaDoZeDesignFactory : IDesignTimeDbContextFactory<PizzariaDoZeDbContext> {
        public PizzariaDoZeDbContext CreateDbContext(string[] args) {
            var configuracao = new ConfigurationBuilder()
               .SetBasePath(Directory.GetCurrentDirectory())
               .AddJsonFile("appsettings.json")
               .Build();

            var connectionString = configuracao.GetConnectionString("SqlServer");

            var optionsBuilder = new DbContextOptionsBuilder<PizzariaDoZeDbContext>();

            optionsBuilder.UseSqlServer(connectionString);

            return new PizzariaDoZeDbContext(optionsBuilder.Options);
        }
    }
}
