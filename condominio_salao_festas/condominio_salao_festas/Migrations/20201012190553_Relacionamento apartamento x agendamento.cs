using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_salao_festas.Migrations
{
    public partial class Relacionamentoapartamentoxagendamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_apartamentos",
                table: "apartamentos");

            migrationBuilder.DropColumn(
                name: "ApartamentoRef",
                table: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "apartamentos",
                newName: "Apartamentos");

            migrationBuilder.AddColumn<int>(
                name: "Apartamento",
                table: "Agendamentos",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_Apartamento",
                table: "Agendamentos",
                column: "Apartamento");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Apartamentos_Apartamento",
                table: "Agendamentos",
                column: "Apartamento",
                principalTable: "Apartamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Apartamentos_Apartamento",
                table: "Agendamentos");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Apartamentos",
                table: "Apartamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_Apartamento",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Apartamento",
                table: "Agendamentos");

            migrationBuilder.RenameTable(
                name: "Apartamentos",
                newName: "apartamentos");

            migrationBuilder.AddColumn<string>(
                name: "ApartamentoRef",
                table: "Agendamentos",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_apartamentos",
                table: "apartamentos",
                column: "Id");
        }
    }
}
