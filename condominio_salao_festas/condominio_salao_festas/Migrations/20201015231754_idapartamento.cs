using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_salao_festas.Migrations
{
    public partial class idapartamento : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Apartamentos_Apartamento",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_Apartamento",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "Apartamento",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "ApartamentoId",
                table: "Agendamentos",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Agendamentos_ApartamentoId",
                table: "Agendamentos",
                column: "ApartamentoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Agendamentos_Apartamentos_ApartamentoId",
                table: "Agendamentos",
                column: "ApartamentoId",
                principalTable: "Apartamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agendamentos_Apartamentos_ApartamentoId",
                table: "Agendamentos");

            migrationBuilder.DropIndex(
                name: "IX_Agendamentos_ApartamentoId",
                table: "Agendamentos");

            migrationBuilder.DropColumn(
                name: "ApartamentoId",
                table: "Agendamentos");

            migrationBuilder.AddColumn<int>(
                name: "Apartamento",
                table: "Agendamentos",
                type: "int",
                nullable: true);

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
    }
}
