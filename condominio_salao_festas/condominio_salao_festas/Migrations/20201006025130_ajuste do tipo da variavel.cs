using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_salao_festas.Migrations
{
    public partial class ajustedotipodavariavel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataAgendamento",
                table: "Agendamentos",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataAgendamento",
                table: "Agendamentos",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
