using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tarea8_Aplicada2.BLL;
using Tarea8_Aplicada2.Models;

namespace Tarea8_Aplicada2.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Usuarios> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source = Data\Usuarios.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().HasData(new Usuarios { UsuarioId = 1, Fecha = DateTime.Now, Nombres = "Administrador", NombreUsuario = "admin", Clave = UsuariosBLL.Encriptar("admin"), Email = "Admin@outlook.com", FechaCreacion = DateTime.Now, FechaModificacion = DateTime.Now, UsuarioIdCreacion = 1 });
        }
    }
}
