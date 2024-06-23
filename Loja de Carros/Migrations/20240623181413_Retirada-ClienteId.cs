using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Loja_de_Carros.Migrations
{
    public partial class RetiradaClienteId : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Cliente_CompradorId",
                table: "Nota");

            migrationBuilder.RenameColumn(
                name: "CompradorId",
                table: "Nota",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_CompradorId",
                table: "Nota",
                newName: "IX_Nota_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Cliente_ClienteId",
                table: "Nota",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Nota_Cliente_ClienteId",
                table: "Nota");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "Nota",
                newName: "CompradorId");

            migrationBuilder.RenameIndex(
                name: "IX_Nota_ClienteId",
                table: "Nota",
                newName: "IX_Nota_CompradorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Nota_Cliente_CompradorId",
                table: "Nota",
                column: "CompradorId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
