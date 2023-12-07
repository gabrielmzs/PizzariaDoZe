using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaDoZe.Dominio.ModuloPizza;

namespace PizzariaDoZe.Infra.Orm.ModuloPizza {
    public class MapeadorPedidoOrm : IEntityTypeConfiguration<Pizza> {
        public void Configure(EntityTypeBuilder<Pizza> builder) {
            builder.ToTable("TBPizza");

            builder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            builder.Property(c => c.Tamanho).HasConversion<int>().IsRequired();
          
            builder.Property(c => c.Borda).HasConversion<int>().IsRequired();

            builder.Property(c => c.Valor).HasColumnType("decimal").IsRequired();

            builder.HasMany(c => c.Sabores).WithMany().UsingEntity(x => x.ToTable("TBPizza_TBSabores"));
        }
    }
}
