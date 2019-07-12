using Microsoft.EntityFrameworkCore.Migrations;

namespace TribunusAPI.Migrations
{
    public partial class FK_Struct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MembroId",
                table: "MotoMembro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotoId",
                table: "MotoMembro",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Membro",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "CargoId",
                table: "Diretoria",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MembroId",
                table: "Diretoria",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AtaId",
                table: "AtaReuniao",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ReuniaoId",
                table: "AtaReuniao",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MotoMembro_MembroId",
                table: "MotoMembro",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_MotoMembro_MotoId",
                table: "MotoMembro",
                column: "MotoId");

            migrationBuilder.CreateIndex(
                name: "IX_Diretoria_CargoId",
                table: "Diretoria",
                column: "CargoId");

            migrationBuilder.CreateIndex(
                name: "IX_Diretoria_MembroId",
                table: "Diretoria",
                column: "MembroId");

            migrationBuilder.CreateIndex(
                name: "IX_AtaReuniao_AtaId",
                table: "AtaReuniao",
                column: "AtaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtaReuniao_ReuniaoId",
                table: "AtaReuniao",
                column: "ReuniaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AtaReuniao_Ata_AtaId",
                table: "AtaReuniao",
                column: "AtaId",
                principalTable: "Ata",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_AtaReuniao_Reuniao_ReuniaoId",
                table: "AtaReuniao",
                column: "ReuniaoId",
                principalTable: "Reuniao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diretoria_Cargo_CargoId",
                table: "Diretoria",
                column: "CargoId",
                principalTable: "Cargo",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Diretoria_Membro_MembroId",
                table: "Diretoria",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MotoMembro_Membro_MembroId",
                table: "MotoMembro",
                column: "MembroId",
                principalTable: "Membro",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MotoMembro_Moto_MotoId",
                table: "MotoMembro",
                column: "MotoId",
                principalTable: "Moto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AtaReuniao_Ata_AtaId",
                table: "AtaReuniao");

            migrationBuilder.DropForeignKey(
                name: "FK_AtaReuniao_Reuniao_ReuniaoId",
                table: "AtaReuniao");

            migrationBuilder.DropForeignKey(
                name: "FK_Diretoria_Cargo_CargoId",
                table: "Diretoria");

            migrationBuilder.DropForeignKey(
                name: "FK_Diretoria_Membro_MembroId",
                table: "Diretoria");

            migrationBuilder.DropForeignKey(
                name: "FK_MotoMembro_Membro_MembroId",
                table: "MotoMembro");

            migrationBuilder.DropForeignKey(
                name: "FK_MotoMembro_Moto_MotoId",
                table: "MotoMembro");

            migrationBuilder.DropIndex(
                name: "IX_MotoMembro_MembroId",
                table: "MotoMembro");

            migrationBuilder.DropIndex(
                name: "IX_MotoMembro_MotoId",
                table: "MotoMembro");

            migrationBuilder.DropIndex(
                name: "IX_Diretoria_CargoId",
                table: "Diretoria");

            migrationBuilder.DropIndex(
                name: "IX_Diretoria_MembroId",
                table: "Diretoria");

            migrationBuilder.DropIndex(
                name: "IX_AtaReuniao_AtaId",
                table: "AtaReuniao");

            migrationBuilder.DropIndex(
                name: "IX_AtaReuniao_ReuniaoId",
                table: "AtaReuniao");

            migrationBuilder.DropColumn(
                name: "MembroId",
                table: "MotoMembro");

            migrationBuilder.DropColumn(
                name: "MotoId",
                table: "MotoMembro");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Membro");

            migrationBuilder.DropColumn(
                name: "CargoId",
                table: "Diretoria");

            migrationBuilder.DropColumn(
                name: "MembroId",
                table: "Diretoria");

            migrationBuilder.DropColumn(
                name: "AtaId",
                table: "AtaReuniao");

            migrationBuilder.DropColumn(
                name: "ReuniaoId",
                table: "AtaReuniao");
        }
    }
}
