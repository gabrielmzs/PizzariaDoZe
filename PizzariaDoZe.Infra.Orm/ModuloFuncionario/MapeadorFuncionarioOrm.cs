using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Dominio.ModuloCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzariaDoZe.Dominio.ModuloFuncionario;

namespace PizzariaDoZe.Infra.Orm.ModuloFuncionario {
    public class MapeadorFuncionarioOrm : IEntityTypeConfiguration<Funcionario> {
        public void Configure(EntityTypeBuilder<Funcionario> builder) {

            builder.ToTable("TBFuncionario");

            builder.Property(c => c.Id).IsRequired().ValueGeneratedNever();

            builder.Property(c => c.Nome).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Email).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.Telefone).HasColumnType("varchar(20)").IsRequired();

            builder.Property(c => c.Cpf).HasColumnType("varchar(20)").IsRequired();

            builder.Property(c => c.Matricula).HasColumnType("varchar(20)").IsRequired();

            builder.Property(c => c.Senha).HasColumnType("varchar(100)").IsRequired();

            builder.Property(c => c.GrupoFuncionario).HasConversion<int>().IsRequired();

            builder.Property(c => c.Complemento).HasColumnType("varchar(20)").IsRequired();

            builder.Property(c => c.NumeroDaCasa).HasColumnType("varchar(20)").IsRequired();

            builder.HasOne(c => c.Endereco).WithMany().IsRequired().HasConstraintName("FK_TBFuncionario_TBEndereco").OnDelete(DeleteBehavior.NoAction);




        }
    }
}
