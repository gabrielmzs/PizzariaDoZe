using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaDoZe.Dominio.ModuloValor;

namespace PizzariaDoZe.Infra.Orm.ModuloValor {
    public class MapeadorValor : IEntityTypeConfiguration<Valor> {
        public void Configure(EntityTypeBuilder<Valor> builder) {
            builder.ToTable("TBValor");

            builder.Property(b => b.Id).IsRequired().ValueGeneratedNever();

            builder.Property(b => b.ValorPizza).HasColumnType("decimal").IsRequired();
            builder.Property(b => b.ValorBorda).HasColumnType("decimal").IsRequired();

            builder.Property(b => b.Tamanho).HasConversion<int>().IsRequired();
            builder.Property(c => c.Categoria).HasConversion<int>().IsRequired();
        }
    }
}
