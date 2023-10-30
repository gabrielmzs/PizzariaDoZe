using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.Compartilhado {
    public class PizzariaDoZeDbContext: DbContext {

        public PizzariaDoZeDbContext(DbContextOptions options) : base(options) {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {


            ILoggerFactory loggerFactory = LoggerFactory.Create((x) => {
                x.AddSerilog(Log.Logger);
            });

            optionsBuilder.UseLoggerFactory(loggerFactory);

            optionsBuilder.EnableSensitiveDataLogging();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {


            Assembly assembly = typeof(PizzariaDoZeDbContext).Assembly;

            modelBuilder.ApplyConfigurationsFromAssembly(assembly);

            base.OnModelCreating(modelBuilder);
        }


        public static class PizzariaDoZeMigradorBancoDados {
            public static bool AtualizarBancoDados(DbContext db) {
                var qtdMigracoesPendentes = db.Database.GetPendingMigrations().Count();

                if (qtdMigracoesPendentes == 0)
                    return false;

                db.Database.Migrate();

                return true;
            }
        }
    }
}
