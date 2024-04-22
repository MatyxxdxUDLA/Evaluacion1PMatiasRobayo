﻿// <auto-generated />
using System;
using Evaluacion1PMatiasRobayo.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Evaluacion1PMatiasRobayo.Migrations
{
    [DbContext(typeof(Evaluacion1PMatiasRobayoContext))]
    [Migration("20240422125116_CambiosBdd")]
    partial class CambiosBdd
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Evaluacion1PMatiasRobayo.Models.Carrera", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("campus")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_carrera")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numero_semestres")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Carrera");
                });

            modelBuilder.Entity("Evaluacion1PMatiasRobayo.Models.MRobayo", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<string>("Apellido")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("CarreraId")
                        .HasColumnType("int");

                    b.Property<bool>("Estudia")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<float>("Promedio")
                        .HasColumnType("real");

                    b.HasKey("ID");

                    b.HasIndex("CarreraId");

                    b.ToTable("MRobayo");
                });

            modelBuilder.Entity("Evaluacion1PMatiasRobayo.Models.MRobayo", b =>
                {
                    b.HasOne("Evaluacion1PMatiasRobayo.Models.Carrera", "Carrera")
                        .WithMany()
                        .HasForeignKey("CarreraId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Carrera");
                });
#pragma warning restore 612, 618
        }
    }
}
