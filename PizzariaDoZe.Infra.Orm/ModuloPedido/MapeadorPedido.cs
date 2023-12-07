using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Dominio.ModuloPedido;

namespace PizzariaDoZe.Infra.Orm.ModuloPedido {
    public class MapeadorPedidoOrm : IEntityTypeConfiguration<Pedido> {
        public void Configure(EntityTypeBuilder<Pedido> builder) {
            builder.ToTable("TBPedido");

            builder.Property(c => c.Id).IsRequired().ValueGeneratedNever();
            builder.HasOne(a => a.Cliente)
                .WithMany()
                .IsRequired()
                .HasConstraintName("FK_TBPedido_TBCliente")
                .OnDelete(DeleteBehavior.NoAction);

            builder.Property(c => c.Data).IsRequired();

            builder.Property(c => c.Entrega).HasConversion<int>().IsRequired();
            builder.Property(c => c.Status).HasConversion<int>().IsRequired();
            builder.Property(c => c.Pagamento).HasConversion<int>().IsRequired();


            builder.Property(c => c.ValorTotal).HasColumnType("decimal").IsRequired();

            builder.HasMany(c => c.Pizzas).WithMany().UsingEntity(x => x.ToTable("TBPedido_TBPizza"));

            builder.Property(c => c.Observacao).IsRequired();

            builder.HasMany(c => c.Bebidas)
           .WithMany()
           .UsingEntity(x => {
               x.ToTable("TBPedido_TBBebida");

               x.Property<int>("Quantidade").IsRequired();
               x.Property<decimal>("ValorTotal").HasColumnType("decimal").IsRequired();
          
           });

        }
    }
}
