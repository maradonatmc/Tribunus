using Microsoft.EntityFrameworkCore.Migrations;

namespace TribunusAPI.Migrations
{
    public partial class FK_Struct_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdMembro",
                table: "MotoMembro");

            migrationBuilder.DropColumn(
                name: "IdMoto",
                table: "MotoMembro");

            migrationBuilder.DropColumn(
                name: "IdGraduacao",
                table: "Membro");

            migrationBuilder.DropColumn(
                name: "IdCargo",
                table: "Diretoria");

            migrationBuilder.DropColumn(
                name: "IdMembro",
                table: "Diretoria");

            migrationBuilder.DropColumn(
                name: "IdReuniao",
                table: "AtaReuniao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdMembro",
                table: "MotoMembro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMoto",
                table: "MotoMembro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdGraduacao",
                table: "Membro",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCargo",
                table: "Diretoria",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdMembro",
                table: "Diretoria",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdReuniao",
                table: "AtaReuniao",
                nullable: false,
                defaultValue: 0);
        }
    }
}
