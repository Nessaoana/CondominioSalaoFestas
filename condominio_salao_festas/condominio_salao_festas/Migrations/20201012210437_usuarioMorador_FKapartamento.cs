using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_salao_festas.Migrations
{
    public partial class usuarioMorador_FKapartamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Apartamento",
                table: "Usuarios",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Apartamentos_Apartamento",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_Apartamento",
                table: "Usuarios");

            migrationBuilder.AlterColumn<string>(
                name: "Apartamento",
                table: "Usuarios",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(int),
                oldNullable: true);
        }
    }
}
