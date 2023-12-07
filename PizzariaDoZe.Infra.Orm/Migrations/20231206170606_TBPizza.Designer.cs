﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PizzariaDoZe.Infra.Orm.Compartilhado;

#nullable disable

namespace PizzariaDoZe.Infra.Orm.Migrations
{
    [DbContext(typeof(PizzariaDoZeDbContext))]
    [Migration("20231206170606_TBPizza")]
    partial class TBPizza
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IngredienteSabor", b =>
                {
                    b.Property<Guid>("IngredientesId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SaborId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IngredientesId", "SaborId");

                    b.HasIndex("SaborId");

                    b.ToTable("TBSabor_TBIngrediente", (string)null);
                });

            modelBuilder.Entity("PizzaSabor", b =>
                {
                    b.Property<Guid>("PizzaId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SaboresId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PizzaId", "SaboresId");

                    b.HasIndex("SaboresId");

                    b.ToTable("TBPizza_TBSabores", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloBebida.Bebida", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("TBBebida", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NumeroDaCasa")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("TBCliente", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloEndereco.Endereco", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Bairro")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Estado")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Pais")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.ToTable("TBEndereco", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Complemento")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<Guid>("EnderecoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("GrupoFuncionario")
                        .HasColumnType("int");

                    b.Property<string>("Matricula")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("NumeroDaCasa")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId");

                    b.ToTable("TBFuncionario", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloIngrediente.Ingrediente", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.HasKey("Id");

                    b.ToTable("TBIngrediente", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloPizza.Pizza", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("Borda")
                        .HasColumnType("bit");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.Property<decimal>("Valor")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("TBPizza", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloSabor.Sabor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<byte[]>("Foto")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("varchar(100)");

                    b.Property<int>("Tipo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("TBSabor", (string)null);
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloValor.Valor", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Categoria")
                        .HasColumnType("int");

                    b.Property<int>("Tamanho")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorBorda")
                        .HasColumnType("decimal");

                    b.Property<decimal>("ValorPizza")
                        .HasColumnType("decimal");

                    b.HasKey("Id");

                    b.ToTable("TBValor", (string)null);
                });

            modelBuilder.Entity("IngredienteSabor", b =>
                {
                    b.HasOne("PizzariaDoZe.Dominio.ModuloIngrediente.Ingrediente", null)
                        .WithMany()
                        .HasForeignKey("IngredientesId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzariaDoZe.Dominio.ModuloSabor.Sabor", null)
                        .WithMany()
                        .HasForeignKey("SaborId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzaSabor", b =>
                {
                    b.HasOne("PizzariaDoZe.Dominio.ModuloPizza.Pizza", null)
                        .WithMany()
                        .HasForeignKey("PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("PizzariaDoZe.Dominio.ModuloSabor.Sabor", null)
                        .WithMany()
                        .HasForeignKey("SaboresId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloCliente.Cliente", b =>
                {
                    b.HasOne("PizzariaDoZe.Dominio.ModuloEndereco.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBCliente_TBEndereco");

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("PizzariaDoZe.Dominio.ModuloFuncionario.Funcionario", b =>
                {
                    b.HasOne("PizzariaDoZe.Dominio.ModuloEndereco.Endereco", "Endereco")
                        .WithMany()
                        .HasForeignKey("EnderecoId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired()
                        .HasConstraintName("FK_TBFuncionario_TBEndereco");

                    b.Navigation("Endereco");
                });
#pragma warning restore 612, 618
        }
    }
}
