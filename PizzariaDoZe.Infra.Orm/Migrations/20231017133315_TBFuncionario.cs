using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzariaDoZe.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TBFuncionario : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBFuncionario",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Email = table.Column<string>(type: "varchar(100)", nullable: false),
                    Telefone = table.Column<string>(type: "varchar(20)", nullable: false),
                    Cpf = table.Column<string>(type: "varchar(20)", nullable: false),
                    Senha = table.Column<string>(type: "varchar(20)", nullable: false),
                    Matricula = table.Column<string>(type: "varchar(20)", nullable: false),
                    GrupoFuncionario = table.Column<int>(type: "int", nullable: false),
                    NumeroDaCasa = table.Column<string>(type: "varchar(20)", nullable: false),
                    Complemento = table.Column<string>(type: "varchar(20)", nullable: false),
                    EnderecoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBFuncionario", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBFuncionario_TBEndereco",
                        column: x => x.EnderecoId,
                        principalTable: "TBEndereco",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBFuncionario_EnderecoId",
                table: "TBFuncionario",
                column: "EnderecoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBFuncionario");
        }
    }
}
