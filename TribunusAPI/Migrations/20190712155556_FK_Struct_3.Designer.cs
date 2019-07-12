﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TribunusAPI.Data;

namespace TribunusAPI.Migrations
{
    [DbContext(typeof(TribunusContext))]
    [Migration("20190712155556_FK_Struct_3")]
    partial class FK_Struct_3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("TribunusAPI.Models.Ata", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<byte[]>("ArquivoAta");

                    b.HasKey("Id");

                    b.ToTable("Ata");
                });

            modelBuilder.Entity("TribunusAPI.Models.AtaReuniao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("AtaId");

                    b.Property<int?>("ReuniaoId");

                    b.HasKey("Id");

                    b.HasIndex("AtaId");

                    b.HasIndex("ReuniaoId");

                    b.ToTable("AtaReuniao");
                });

            modelBuilder.Entity("TribunusAPI.Models.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DscCargo");

                    b.HasKey("Id");

                    b.ToTable("Cargo");
                });

            modelBuilder.Entity("TribunusAPI.Models.Diretoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CargoId");

                    b.Property<DateTime>("DatFinalFuncao");

                    b.Property<DateTime>("DatInicioFuncao");

                    b.Property<bool>("FlgAtivo");

                    b.Property<int?>("MembroId");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("MembroId");

                    b.ToTable("Diretoria");
                });

            modelBuilder.Entity("TribunusAPI.Models.Graduacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DscGraduacao");

                    b.HasKey("Id");

                    b.ToTable("Graduacao");
                });

            modelBuilder.Entity("TribunusAPI.Models.Membro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ApelidoMembro");

                    b.Property<DateTime>("DatIngresso");

                    b.Property<DateTime>("DatNascimento");

                    b.Property<DateTime?>("DatUltAtualizacao");

                    b.Property<string>("DscCnh");

                    b.Property<bool>("FlgAdAeternum");

                    b.Property<bool>("FlgAtivo");

                    b.Property<int?>("GraduacaoId");

                    b.Property<string>("NomeMembro");

                    b.Property<string>("Password");

                    b.HasKey("Id");

                    b.HasIndex("GraduacaoId");

                    b.ToTable("Membro");
                });

            modelBuilder.Entity("TribunusAPI.Models.Moto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DscAno");

                    b.Property<string>("DscMarca");

                    b.Property<string>("DscModelo");

                    b.Property<string>("DscPlaca");

                    b.HasKey("Id");

                    b.ToTable("Moto");
                });

            modelBuilder.Entity("TribunusAPI.Models.MotoMembro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("MembroId");

                    b.Property<int?>("MotoId");

                    b.HasKey("Id");

                    b.HasIndex("MembroId");

                    b.HasIndex("MotoId");

                    b.ToTable("MotoMembro");
                });

            modelBuilder.Entity("TribunusAPI.Models.Reuniao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DatReuniao");

                    b.Property<string>("DscEnderecoReuniao");

                    b.Property<string>("DscLocalReuniao");

                    b.HasKey("Id");

                    b.ToTable("Reuniao");
                });

            modelBuilder.Entity("TribunusAPI.Models.AtaReuniao", b =>
                {
                    b.HasOne("TribunusAPI.Models.Ata", "Ata")
                        .WithMany("AtaReuniao")
                        .HasForeignKey("AtaId");

                    b.HasOne("TribunusAPI.Models.Reuniao", "Reuniao")
                        .WithMany("AtaReuniao")
                        .HasForeignKey("ReuniaoId");
                });

            modelBuilder.Entity("TribunusAPI.Models.Diretoria", b =>
                {
                    b.HasOne("TribunusAPI.Models.Cargo", "Cargo")
                        .WithMany("Diretoria")
                        .HasForeignKey("CargoId");

                    b.HasOne("TribunusAPI.Models.Membro", "Membro")
                        .WithMany("Diretoria")
                        .HasForeignKey("MembroId");
                });

            modelBuilder.Entity("TribunusAPI.Models.Membro", b =>
                {
                    b.HasOne("TribunusAPI.Models.Graduacao", "Graduacao")
                        .WithMany("Membro")
                        .HasForeignKey("GraduacaoId");
                });

            modelBuilder.Entity("TribunusAPI.Models.MotoMembro", b =>
                {
                    b.HasOne("TribunusAPI.Models.Membro", "Membro")
                        .WithMany("MotoMembros")
                        .HasForeignKey("MembroId");

                    b.HasOne("TribunusAPI.Models.Moto", "Moto")
                        .WithMany("MotoMembros")
                        .HasForeignKey("MotoId");
                });
#pragma warning restore 612, 618
        }
    }
}