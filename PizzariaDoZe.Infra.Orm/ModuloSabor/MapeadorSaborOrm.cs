using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaDoZe.Dominio.ModuloSabor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloSabor {
    public class MapeadorSaborOrm : IEntityTypeConfiguration<Sabor> {
        public void Configure(EntityTypeBuilder<Sabor> builder) {
            builder.ToTable("TBSabor");

            builder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            builder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Categoria).HasConversion<int>().IsRequired();
            builder.Property(c => c.Tipo).HasConversion<int>().IsRequired();


            builder.HasMany(c => c.Ingredientes).WithMany().UsingEntity(x => x.ToTable("TBSabor_TBIngrediente"));
        }
    }
}
