// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Tarea8_Aplicada2.DAL;

namespace Tarea8_Aplicada2.Migrations
{
    [DbContext(typeof(Contexto))]
    partial class ContextoModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Tarea8_Aplicada2.Models.Usuarios", b =>
                {
                    b.Property<int>("UsuarioId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaCreacion")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("FechaModificacion")
                        .HasColumnType("TEXT");

                    b.Property<string>("NombreUsuario")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("UsuarioIdCreacion")
                        .HasColumnType("INTEGER");

                    b.HasKey("UsuarioId");

                    b.ToTable("Usuarios");

                    b.HasData(
                        new
                        {
                            UsuarioId = 1,
                            Clave = "YQBkAG0AaQBuAA==",
                            Email = "Admin@outlook.com",
                            Fecha = new DateTime(2021, 7, 5, 17, 18, 41, 476, DateTimeKind.Local).AddTicks(9986),
                            FechaCreacion = new DateTime(2021, 7, 5, 17, 18, 41, 489, DateTimeKind.Local).AddTicks(1063),
                            FechaModificacion = new DateTime(2021, 7, 5, 17, 18, 41, 489, DateTimeKind.Local).AddTicks(1190),
                            NombreUsuario = "admin",
                            Nombres = "Administrador",
                            UsuarioIdCreacion = 1
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
