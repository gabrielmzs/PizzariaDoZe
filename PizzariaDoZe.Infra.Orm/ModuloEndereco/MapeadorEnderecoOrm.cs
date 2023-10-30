using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PizzariaDoZe.Dominio.ModuloEndereco;
using PizzariaDoZe.Dominio.ModuloIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Infra.Orm.ModuloEndereco {
    internal class MapeadorEnderecoOrm : IEntityTypeConfiguration<Endereco> {
        public void Configure(EntityTypeBuilder<Endereco> builder) {

            builder.ToTable("TBEndereco");

            builder.Property(p => p.Id).IsRequired().ValueGeneratedNever();

            builder.Property(p => p.Cep).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Logradouro).HasColumnType("varchar(100)").IsRequired();
            builder.Property(p => p.Bairro).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Cidade).HasColumnType("varchar(50)").IsRequired();
            builder.Property(p => p.Estado).HasColumnType("varchar(20)").IsRequired();
            builder.Property(p => p.Pais).HasColumnType("varchar(20)").IsRequired();
        }
    }
}
