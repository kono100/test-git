﻿// <auto-generated />
using System;
using Gestao.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Gestao.Migrations
{
    [DbContext(typeof(IESContext))]
    [Migration("20231222145028_Initial")]
    partial class Initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Gestao.Models.Morador", b =>
                {
                    b.Property<long?>("MoradorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("MoradorID"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNasc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroAP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telefone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MoradorID");

                    b.ToTable("Morador");
                });

            modelBuilder.Entity("Gestao.Models.Reservas", b =>
                {
                    b.Property<long?>("ReservasID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("ReservasID"));

                    b.Property<DateTime>("DataHoraRes")
                        .HasColumnType("datetime2");

                    b.Property<string>("DuracaoReserva")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("fk_MoradorID")
                        .HasColumnType("bigint");

                    b.HasKey("ReservasID");

                    b.HasIndex("fk_MoradorID");

                    b.ToTable("Reservas");
                });

            modelBuilder.Entity("Gestao.Models.Veiculo", b =>
                {
                    b.Property<long?>("VeiculoID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("VeiculoID"));

                    b.Property<string>("Cor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Marca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Modelo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("VisitanteID")
                        .HasColumnType("bigint");

                    b.Property<long?>("fk_MoradorID")
                        .HasColumnType("bigint");

                    b.HasKey("VeiculoID");

                    b.HasIndex("fk_MoradorID");

                    b.ToTable("Veiculo");
                });

            modelBuilder.Entity("Gestao.Models.Visitante", b =>
                {
                    b.Property<long?>("VisitanteID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long?>("VisitanteID"));

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DataNasc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EndDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Observacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("fk_MoradorID")
                        .HasColumnType("bigint");

                    b.HasKey("VisitanteID");

                    b.HasIndex("fk_MoradorID");

                    b.ToTable("Visitante");
                });

            modelBuilder.Entity("Gestao.Models.Reservas", b =>
                {
                    b.HasOne("Gestao.Models.Morador", "Morador")
                        .WithMany("Reservas")
                        .HasForeignKey("fk_MoradorID");

                    b.Navigation("Morador");
                });

            modelBuilder.Entity("Gestao.Models.Veiculo", b =>
                {
                    b.HasOne("Gestao.Models.Morador", "Morador")
                        .WithMany("Veiculos")
                        .HasForeignKey("fk_MoradorID");

                    b.Navigation("Morador");
                });

            modelBuilder.Entity("Gestao.Models.Visitante", b =>
                {
                    b.HasOne("Gestao.Models.Morador", "Morador")
                        .WithMany("Visitantes")
                        .HasForeignKey("fk_MoradorID");

                    b.Navigation("Morador");
                });

            modelBuilder.Entity("Gestao.Models.Morador", b =>
                {
                    b.Navigation("Reservas");

                    b.Navigation("Veiculos");

                    b.Navigation("Visitantes");
                });
#pragma warning restore 612, 618
        }
    }
}