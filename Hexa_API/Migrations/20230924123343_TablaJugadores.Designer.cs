﻿// <auto-generated />
using Hexa_API.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Hexa_API.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    [Migration("20230924123343_TablaJugadores")]
    partial class TablaJugadores
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Hexa_API.Domain.Models.Jugadores", b =>
                {
                    b.Property<string>("IdJugador")
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR");

                    b.Property<int>("Camiseta")
                        .HasColumnType("int");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("CodigoEquipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdEquipo")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("NombreEquipo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("campeonatos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdJugador");

                    b.ToTable("Jugadores");
                });
#pragma warning restore 612, 618
        }
    }
}
