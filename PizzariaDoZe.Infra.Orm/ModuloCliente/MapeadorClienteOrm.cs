using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloCliente {
    public class MapeadorClienteOrm : IEntityTypeConfiguration<Cliente> {
        public void Configure(EntityTypeBuilder<Cliente> clienteBuilder) {

            clienteBuilder.ToTable("TBCliente");

            clienteBuilder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            clienteBuilder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Email).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Telefone).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Cpf).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.Complemento).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.Property(c => c.NumeroDaCasa).HasColumnType("varchar(100)").IsRequired();

            clienteBuilder.HasOne(c => c.Endereco).WithMany().IsRequired().HasConstraintName("FK_TBCliente_TBEndereco").OnDelete(DeleteBehavior.NoAction);


        }
    }
}
