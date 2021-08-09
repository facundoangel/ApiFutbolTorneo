using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiFutbolTorneo.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FutbolDBEquipos",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    equipo = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    color = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutbolDBEquipos", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "FutbolDBJugadoras",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    dni = table.Column<int>(type: "int", nullable: false),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    apellido = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    equipojugando = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FutbolDBJugadoras", x => x.id);
                });

            migrationBuilder.InsertData(
                table: "FutbolDBEquipos",
                columns: new[] { "id", "color", "equipo" },
                values: new object[] { 1, "celeste", "arsenal" });

            migrationBuilder.InsertData(
                table: "FutbolDBEquipos",
                columns: new[] { "id", "color", "equipo" },
                values: new object[] { 2, "rojo", "independiente" });

            migrationBuilder.CreateIndex(
                name: "IX_FutbolDBEquipos_equipo",
                table: "FutbolDBEquipos",
                column: "equipo",
                unique: true,
                filter: "[equipo] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_FutbolDBJugadoras_dni",
                table: "FutbolDBJugadoras",
                column: "dni",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FutbolDBEquipos");

            migrationBuilder.DropTable(
                name: "FutbolDBJugadoras");
        }
    }
}
