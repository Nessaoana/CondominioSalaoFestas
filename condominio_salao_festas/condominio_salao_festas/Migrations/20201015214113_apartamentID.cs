using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_salao_festas.Migrations
{
    public partial class apartamentID : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Apartamentos_Apartamento",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Apartamento",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "Apartamento",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "ApartamentoId",
                table: "Usuarios",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ApartamentoId",
                table: "Usuarios",
                column: "ApartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Apartamentos_ApartamentoId",
                table: "Usuarios",
                column: "ApartamentoId",
                principalTable: "Apartamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Apartamentos_ApartamentoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ApartamentoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ApartamentoId",
                table: "Usuarios");

            migrationBuilder.AddColumn<int>(
                name: "Apartamento",
                table: "Usuarios",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_Apartamento",
                table: "Usuarios",
                column: "Apartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Apartamentos_Apartamento",
                table: "Usuarios",
                column: "Apartamento",
                principalTable: "Apartamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
