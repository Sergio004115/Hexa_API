using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hexa_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaJugadores : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Jugadores",
                columns: table => new
                {
                    IdJugador = table.Column<string>(type: "VARCHAR(128)", maxLength: 128, nullable: false),
                    Codigo = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Nombres = table.Column<string>(type: "VARCHAR(50)", maxLength: 50, nullable: false),
                    Camiseta = table.Column<int>(type: "int", nullable: false),
                    campeonatos = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdEquipo = table.Column<string>(type: "VARCHAR(128)", maxLength: 128, nullable: false),
                    CodigoEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NombreEquipo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Jugadores", x => x.IdJugador);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Jugadores");
        }
    }
}
