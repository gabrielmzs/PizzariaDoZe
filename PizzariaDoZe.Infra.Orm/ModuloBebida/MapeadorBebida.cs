using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaDoZe.Dominio.ModuloBebida;

namespace PizzariaDoZe.Infra.Orm.ModuloBebida {
    internal class MapeadorBebida : IEntityTypeConfiguration<Bebida> {
        public void Configure(EntityTypeBuilder<Bebida> builder) {
            builder.ToTable("TBBebida");

            builder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            builder.Property(c => c.Nome).HasColumnType("varchar(50)").IsRequired();
            builder.Property(c => c.Valor).HasColumnType("decimal").IsRequired();

            builder.Property(c => c.Tipo).HasConversion<int>().IsRequired();
            builder.Property(c => c.Tamanho).HasConversion<int>().IsRequired();
            builder.Ignore(c => c.ValorTotal);
            builder.Ignore(c => c.Quantidade);

        }
    }
}
