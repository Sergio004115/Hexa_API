using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Hexa_API.Migrations
{
    /// <inheritdoc />
    public partial class TablaEquipos_Relacion_uno_muchos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipos",
                columns: table => new
                {
                    IdEquipo = table.Column<string>(type: "VARCHAR(128)", maxLength: 128, nullable: false),
                    Codigo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipos", x => x.IdEquipo);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Jugadores_IdEquipo",
                table: "Jugadores",
                column: "IdEquipo");

            migrationBuilder.AddForeignKey(
                name: "FK_Jugadores_Equipos_IdEquipo",
                table: "Jugadores",
                column: "IdEquipo",
                principalTable: "Equipos",
                principalColumn: "IdEquipo",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Jugadores_Equipos_IdEquipo",
                table: "Jugadores");

            migrationBuilder.DropTable(
                name: "Equipos");

            migrationBuilder.DropIndex(
                name: "IX_Jugadores_IdEquipo",
                table: "Jugadores");
        }
    }
}
