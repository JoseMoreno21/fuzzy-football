using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginFuzzy.Migrations
{
    public partial class Extend_IdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Futbolista",
                columns: table => new
                {
                    IdFutbolista = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    altura = table.Column<double>(type: "float", nullable: false),
                    peso = table.Column<double>(type: "float", nullable: false),
                    musculatura = table.Column<double>(type: "float", nullable: false),
                    velocidad = table.Column<double>(type: "float", nullable: false),
                    resistencia = table.Column<double>(type: "float", nullable: false),
                    agilidad = table.Column<double>(type: "float", nullable: false),
                    confianza = table.Column<double>(type: "float", nullable: false),
                    concentracion = table.Column<double>(type: "float", nullable: false),
                    decisiones = table.Column<double>(type: "float", nullable: false),
                    creatividad = table.Column<double>(type: "float", nullable: false),
                    dribling = table.Column<double>(type: "float", nullable: false),
                    pases = table.Column<double>(type: "float", nullable: false),
                    DC = table.Column<double>(type: "float", nullable: false),
                    DL = table.Column<double>(type: "float", nullable: false),
                    PT = table.Column<double>(type: "float", nullable: false),
                    MC = table.Column<double>(type: "float", nullable: false),
                    FW = table.Column<double>(type: "float", nullable: false),
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Futbolista", x => x.IdFutbolista);
                    table.ForeignKey(
                        name: "FK_Futbolista_AspNetUsers_Id",
                        column: x => x.Id,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Futbolista_Id",
                table: "Futbolista",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Futbolista");
        }
    }
}
