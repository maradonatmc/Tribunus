using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TribunusAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ata",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArquivoAta = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ata", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtaReuniao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdAta = table.Column<int>(nullable: false),
                    IdReuniao = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtaReuniao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cargo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DscCargo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Diretoria",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMembro = table.Column<int>(nullable: false),
                    IdCargo = table.Column<int>(nullable: false),
                    DatInicioFuncao = table.Column<DateTime>(nullable: false),
                    DatFinalFuncao = table.Column<DateTime>(nullable: false),
                    FlgAtivo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Diretoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Graduacao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DscGraduacao = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Graduacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DscMarca = table.Column<string>(nullable: true),
                    DscModelo = table.Column<string>(nullable: true),
                    DscAno = table.Column<string>(nullable: true),
                    DscPlaca = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moto", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MotoMembro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    IdMoto = table.Column<int>(nullable: false),
                    IdMembro = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MotoMembro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reuniao",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    DscLocalReuniao = table.Column<string>(nullable: true),
                    DscEnderecoReuniao = table.Column<string>(nullable: true),
                    DatReuniao = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reuniao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Membro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    NomeMembro = table.Column<string>(nullable: true),
                    DatNascimento = table.Column<DateTime>(nullable: false),
                    ApelidoMembro = table.Column<string>(nullable: true),
                    DatIngresso = table.Column<DateTime>(nullable: false),
                    GraduacaoId = table.Column<int>(nullable: true),
                    IdGraduacao = table.Column<int>(nullable: false),
                    DscCnh = table.Column<string>(nullable: true),
                    FlgAdAeternum = table.Column<bool>(nullable: false),
                    FlgAtivo = table.Column<bool>(nullable: false),
                    DatUltAtualizacao = table.Column<DateTime>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Membro", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Membro_Graduacao_GraduacaoId",
                        column: x => x.GraduacaoId,
                        principalTable: "Graduacao",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Membro_GraduacaoId",
                table: "Membro",
                column: "GraduacaoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ata");

            migrationBuilder.DropTable(
                name: "AtaReuniao");

            migrationBuilder.DropTable(
                name: "Cargo");

            migrationBuilder.DropTable(
                name: "Diretoria");

            migrationBuilder.DropTable(
                name: "Membro");

            migrationBuilder.DropTable(
                name: "Moto");

            migrationBuilder.DropTable(
                name: "MotoMembro");

            migrationBuilder.DropTable(
                name: "Reuniao");

            migrationBuilder.DropTable(
                name: "Graduacao");
        }
    }
}
