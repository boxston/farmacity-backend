﻿// <auto-generated />
using System;
using Farmacity_Backend;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Farmacity_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241105002804_CodigoBarra")]
    partial class CodigoBarra
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Farmacity_Backend.Entity.CodigoBarra", b =>
                {
                    b.Property<int>("ProductoId")
                        .HasColumnType("int");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductoId");

                    b.ToTable("CodigoBarra");
                });

            modelBuilder.Entity("Farmacity_Backend.Entity.Producto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<int>("CantidadEnStock")
                        .HasColumnType("int");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Farmacity_Backend.Entity.CodigoBarra", b =>
                {
                    b.HasOne("Farmacity_Backend.Entity.Producto", "Producto")
                        .WithOne("CodigoBarra")
                        .HasForeignKey("Farmacity_Backend.Entity.CodigoBarra", "ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Farmacity_Backend.Entity.Producto", b =>
                {
                    b.Navigation("CodigoBarra");
                });
#pragma warning restore 612, 618
        }
    }
}