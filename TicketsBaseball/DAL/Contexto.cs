using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using TicketsDeportivos.Entidades;

namespace TicketsDeportivos.DAL
{
    // Aqui agregamos public tambien, para que la clase pueda ser encontrada en cualquier parte del proyecto, 
    //y heredamos de  DbContext para que EntityFramework pueda hacer su magia
    public class Contexto : DbContext
    {
        public DbSet<Partido> Partidos { get; set; }
        public DbSet<TipoPartido> TipoPartidos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Venta> Ventas { get; set; }

        public DbSet<PartidoDetalle> PartidoDetalles { get; set; }
        // base("ConStr") para pasar la conexion a la clase base de EntityFramework 
        public Contexto() : base("ConStr")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        
    }
}
