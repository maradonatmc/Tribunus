using Microsoft.EntityFrameworkCore.Migrations;

namespace TribunusAPI.Migrations
{
    public partial class FK_Struct_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdAta",
                table: "AtaReuniao");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdAta",
                table: "AtaReuniao",
                nullable: false,
                defaultValue: 0);
        }
    }
}
