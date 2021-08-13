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
                values: new object[,]
                {
                    { 1, "celeste", "Arsenal" },
                    { 2, "rojo", "Independiente" },
                    { 3, "verde y rojo", "Banfield" },
                    { 4, "rojo y azul", "Tigre" },
                    { 5, "celeste y blanco", "Racing" },
                    { 6, "rojo y blanco", "River" }
                });

            migrationBuilder.InsertData(
                table: "FutbolDBJugadoras",
                columns: new[] { "id", "apellido", "dni", "equipojugando", "nombre" },
                values: new object[,]
                {
                    { 28, "Jacinto", 42840927, "Banfield", "Gabriela" },
                    { 29, "Suarez", 42940928, "Banfield", "Tamara" },
                    { 30, "Martinez", 43040929, "Banfield", "Belen" },
                    { 31, "Espinoza", 43140900, "Banfield", "Violeta" },
                    { 32, "Godoy", 43240921, "Racing", "Catalina" },
                    { 33, "Perez", 43340922, "Racing", "Martina" },
                    { 34, "Alvarez", 34640923, "Racing", "Marta" },
                    { 35, "Perez", 43540924, "Racing", "Natalia" },
                    { 36, "Garcia", 43640925, "Racing", "Guadalupe" },
                    { 37, "Fole", 43740926, "Racing", "Oriana" },
                    { 41, "Suarez", 44140920, "River", "Carla" },
                    { 39, "Naupari", 43940928, "Racing", "Patricia" },
                    { 27, "Ramirez", 42740926, "Banfield", "Abril" },
                    { 42, "Gutierrez", 44240920, "River", "Martina" },
                    { 43, "Souza", 44340920, "River", "Marta" },
                    { 44, "Perez", 44440921, "River", "Natalia" },
                    { 45, "Alvarez", 44540922, "River", "Rocio" },
                    { 46, "Fole", 44640923, "River", "Micaela" },
                    { 47, "Gonzalez", 44740924, "River", "Antonela" },
                    { 48, "Ramirez", 44840925, "River", "Diana" },
                    { 49, "Jacinto", 44940927, "River", "Gabriela" },
                    { 38, "Gonzalez", 43840927, "Racing", "Mariana" },
                    { 26, "Gonzalez", 42640965, "Banfield", "Antonela" },
                    { 22, "Espinonza", 42240921, "Banfield", "Marta" },
                    { 23, "Tarantini", 42340922, "Banfield", "Julie" },
                    { 1, "Suarez", 40640921, "Arsenal", "Carla" },
                    { 2, "Gutierrez", 41640822, "Arsenal", "Martina" },
                    { 3, "Souza", 42680923, "Arsenal", "Marta" },
                    { 4, "Perez", 43640924, "Arsenal", "Natalia" },
                    { 5, "Alvarez", 44640925, "Arsenal", "Rocio" },
                    { 6, "Fole", 45640926, "Arsenal", "Micaela" },
                    { 7, "Gonzalez", 46640927, "Arsenal", "Antonela" },
                    { 8, "Ramirez", 47640928, "Arsenal", "Beatriz" },
                    { 9, "Jacinto", 48640929, "Arsenal", "Gabriela" },
                    { 10, "Suarez", 49640928, "Arsenal", "Tamara" },
                    { 25, "Fole", 42540924, "Banfield", "Micaela" }
                });

            migrationBuilder.InsertData(
                table: "FutbolDBJugadoras",
                columns: new[] { "id", "apellido", "dni", "equipojugando", "nombre" },
                values: new object[,]
                {
                    { 11, "Martinez", 41040929, "Arsenal", "Belen" },
                    { 13, "Alvarez", 94120923, "Independiente", "Martina" },
                    { 14, "Souza", 41340924, "Independiente", "Eugenia" },
                    { 15, "Gonzalez", 41440925, "Independiente", "Oriana" },
                    { 16, "Alvarez", 41540926, "Independiente", "Marina" },
                    { 17, "Angel", 41640977, "Independiente", "Marta" },
                    { 18, "Maritini", 41740928, "Independiente", "Romina" },
                    { 19, "Capelletti", 41940929, "Independiente", "Juliana" },
                    { 20, "Suarez", 42040928, "Banfield", "Martina" },
                    { 21, "Gutierrez", 42140929, "Banfield", "Cecilia" },
                    { 50, "Suarez", 45040956, "River", "Tamara" },
                    { 12, "Perez", 41140922, "Independiente", "Marina" },
                    { 51, "Martinez", 45140929, "River", "Belen" }
                });

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
