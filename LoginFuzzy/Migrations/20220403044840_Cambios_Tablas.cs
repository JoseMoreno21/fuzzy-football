using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LoginFuzzy.Migrations
{
    public partial class Cambios_Tablas : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Futbolista_AspNetUsers_Id",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "DC",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "DL",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "FW",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "MC",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "PT",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "agilidad",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "altura",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "concentracion",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "confianza",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "creatividad",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "decisiones",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "dribling",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "musculatura",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "nombre",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "pases",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "peso",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "resistencia",
                table: "Futbolista");

            migrationBuilder.DropColumn(
                name: "velocidad",
                table: "Futbolista");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Futbolista",
                newName: "ApplicationUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Futbolista_Id",
                table: "Futbolista",
                newName: "IX_Futbolista_ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Futbolista_AspNetUsers_ApplicationUserId",
                table: "Futbolista",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Futbolista_AspNetUsers_ApplicationUserId",
                table: "Futbolista");

            migrationBuilder.RenameColumn(
                name: "ApplicationUserId",
                table: "Futbolista",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_Futbolista_ApplicationUserId",
                table: "Futbolista",
                newName: "IX_Futbolista_Id");

            migrationBuilder.AddColumn<double>(
                name: "DC",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "DL",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "FW",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "MC",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "PT",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "agilidad",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "altura",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "concentracion",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "confianza",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "creatividad",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "decisiones",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "dribling",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "musculatura",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "nombre",
                table: "Futbolista",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "pases",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "peso",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "resistencia",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "velocidad",
                table: "Futbolista",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddForeignKey(
                name: "FK_Futbolista_AspNetUsers_Id",
                table: "Futbolista",
                column: "Id",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
