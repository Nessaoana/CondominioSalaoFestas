using Microsoft.EntityFrameworkCore.Migrations;

namespace condominio_salao_festas.Migrations
{
    public partial class Usuarios : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Moradores",
                columns: table => new
                {
                    Apartamento = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moradores", x => x.Apartamento);
                });

            migrationBuilder.CreateTable(
                name: "UsuariosAdmin",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Nome = table.Column<string>(nullable: true),
                    Senha = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuariosAdmin", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Moradores");

            migrationBuilder.DropTable(
                name: "UsuariosAdmin");
        }
    }
}
