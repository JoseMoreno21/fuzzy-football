using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginFuzzy.Migrations
{
    public partial class NuevoCampoFinalizacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "finalizacion",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "finalizacion",
                table: "Futbolista");
        }
    }
}
