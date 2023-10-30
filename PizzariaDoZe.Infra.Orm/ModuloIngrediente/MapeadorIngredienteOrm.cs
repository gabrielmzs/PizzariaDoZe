using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloIngrediente {
    internal class MapeadorIngredienteOrm : IEntityTypeConfiguration<Ingrediente> {
        public void Configure(EntityTypeBuilder<Ingrediente> ingredienteBuilder) {

            ingredienteBuilder.ToTable("TBIngrediente");

            ingredienteBuilder.Property(p => p.Id).IsRequired().ValueGeneratedNever();

            ingredienteBuilder.Property(p => p.Nome).HasColumnType("varchar(100)").IsRequired();
        }
    }
}
