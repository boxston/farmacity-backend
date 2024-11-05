﻿// <auto-generated />
using System;
using Farmacity_Backend.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Farmacity_Backend.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20241105053920_cambioCodigoBarra")]
    partial class cambioCodigoBarra
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

                    b.Property<string>("Codigo")
                        .HasMaxLength(13)
                        .HasColumnType("nvarchar(13)");

                    b.Property<bool>("Activo")
                        .HasColumnType("bit");

                    b.Property<DateTime>("FechaAlta")
                        .HasColumnType("datetime2");

                    b.HasKey("ProductoId", "Codigo");

                    b.ToTable("CodigoBarras");
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
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("GETDATE()");

                    b.Property<DateTime?>("FechaModificacion")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Precio")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.ToTable("Productos");
                });

            modelBuilder.Entity("Farmacity_Backend.Entity.CodigoBarra", b =>
                {
                    b.HasOne("Farmacity_Backend.Entity.Producto", "Producto")
                        .WithMany("CodigoBarras")
                        .HasForeignKey("ProductoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Producto");
                });

            modelBuilder.Entity("Farmacity_Backend.Entity.Producto", b =>
                {
                    b.Navigation("CodigoBarras");
                });
#pragma warning restore 612, 618
        }
    }
}