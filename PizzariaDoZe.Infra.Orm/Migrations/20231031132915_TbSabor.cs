using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzariaDoZe.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TbSabor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBSabor",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Tipo = table.Column<int>(type: "int", nullable: false),
                    Categoria = table.Column<int>(type: "int", nullable: false),
                    Foto = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSabor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TBSabor_TBIngrediente",
                columns: table => new
                {
                    IngredientesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SaborId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBSabor_TBIngrediente", x => new { x.IngredientesId, x.SaborId });
                    table.ForeignKey(
                        name: "FK_TBSabor_TBIngrediente_TBIngrediente_IngredientesId",
                        column: x => x.IngredientesId,
                        principalTable: "TBIngrediente",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBSabor_TBIngrediente_TBSabor_SaborId",
                        column: x => x.SaborId,
                        principalTable: "TBSabor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBSabor_TBIngrediente_SaborId",
                table: "TBSabor_TBIngrediente",
                column: "SaborId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBSabor_TBIngrediente");

            migrationBuilder.DropTable(
                name: "TBSabor");
        }
    }
}
