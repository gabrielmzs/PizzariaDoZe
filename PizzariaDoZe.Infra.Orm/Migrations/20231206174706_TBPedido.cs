using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PizzariaDoZe.Infra.Orm.Migrations
{
    /// <inheritdoc />
    public partial class TBPedido : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TBPedido",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClienteId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Entrega = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Pagamento = table.Column<int>(type: "int", nullable: false),
                    ValorTotal = table.Column<decimal>(type: "decimal(18,0)", nullable: false),
                    Observacao = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBCliente",
                        column: x => x.ClienteId,
                        principalTable: "TBCliente",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "TBPedido_TBBebida",
                columns: table => new
                {
                    BebidasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantidade = table.Column<int>(type: "int", nullable: false),
                    Valor = table.Column<decimal>(type: "decimal(18,0)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido_TBBebida", x => new { x.BebidasId, x.PedidoId });
                    table.ForeignKey(
                        name: "FK_TBPedido_TBBebida_TBBebida_BebidasId",
                        column: x => x.BebidasId,
                        principalTable: "TBBebida",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBBebida_TBPedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "TBPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TBPedido_TBPizza",
                columns: table => new
                {
                    PedidoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PizzasId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TBPedido_TBPizza", x => new { x.PedidoId, x.PizzasId });
                    table.ForeignKey(
                        name: "FK_TBPedido_TBPizza_TBPedido_PedidoId",
                        column: x => x.PedidoId,
                        principalTable: "TBPedido",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TBPedido_TBPizza_TBPizza_PizzasId",
                        column: x => x.PizzasId,
                        principalTable: "TBPizza",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_ClienteId",
                table: "TBPedido",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_TBBebida_PedidoId",
                table: "TBPedido_TBBebida",
                column: "PedidoId");

            migrationBuilder.CreateIndex(
                name: "IX_TBPedido_TBPizza_PizzasId",
                table: "TBPedido_TBPizza",
                column: "PizzasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TBPedido_TBBebida");

            migrationBuilder.DropTable(
                name: "TBPedido_TBPizza");

            migrationBuilder.DropTable(
                name: "TBPedido");
        }
    }
}
