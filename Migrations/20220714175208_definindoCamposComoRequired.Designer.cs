﻿// <auto-generated />
using Fiap.Web.AspNet3.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Fiap.Web.AspNet3.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220714175208_definindoCamposComoRequired")]
    partial class definindoCamposComoRequired
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Fiap.Web.AspNet3.Models.GerenteModel", b =>
                {
                    b.Property<int>("GerenteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RepresentanteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GerenteId"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Sobrenome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("GerenteId");

                    b.ToTable("Gerente");
                });

            modelBuilder.Entity("Fiap.Web.AspNet3.Models.RepresentanteModel", b =>
                {
                    b.Property<int>("RepresentanteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("RepresentanteId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RepresentanteId"), 1L, 1);

                    b.Property<string>("NomeRepresentante")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("RepresentanteId");

                    b.ToTable("Representante");
                });
#pragma warning restore 612, 618
        }
    }
}
