using Microsoft.EntityFrameworkCore.Migrations;

namespace Hackaton.App.Persistencia.Migrations
{
    public partial class MigraOchomil : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Novedades",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    fecha_de_novedad = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    dias_novedad_activa = table.Column<int>(type: "int", nullable: false),
                    texto_explicativo = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Novedades", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Novedades");
        }
    }
}
