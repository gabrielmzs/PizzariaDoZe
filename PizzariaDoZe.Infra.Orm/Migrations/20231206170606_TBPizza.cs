using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzariaDoZe.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TBPizza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBPizza",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Tamanho = table.Column<int>(type: "int", nullable: false),
                    Borda = table.Column<bool>(type: "bit", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPizza", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBPizza_TBSabores",
                columns: table => new
                {
                    PizzaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaboresId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPizza_TBSabores", x => new { x.PizzaId, x.SaboresId });
                    table.ForeignKey(
                        name: "FK_TBPizza_TBSabores_TBPizza_PizzaId",
                        column: x => x.PizzaId,
                        principalTable: "TBPizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBPizza_TBSabores_TBSabor_SaboresId",
                        column: x => x.SaboresId,
                        principalTable: "TBSabor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBPizza_TBSabores_SaboresId",
                table: "TBPizza_TBSabores",
                column: "SaboresId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPizza_TBSabores");

            migrationBuilder.DropTable(
                name: "TBPizza");
        }
    }
}
