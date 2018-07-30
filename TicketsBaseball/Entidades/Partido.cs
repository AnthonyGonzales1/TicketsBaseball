using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using TicketsDeportivos.DAL;

namespace TicketsDeportivos.Entidades
{
    public class Partido
    {
        [Key]
        public int PartidoId { get; set; }
        public int TipoPartidoId { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public string Lugar { get; set; }
        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public List<PartidoDetalle> Detalle { get; set; }

        public Partido()
        {
            this.PartidoId = 0;
            this.TipoPartidoId = 0;
            this.Nombre = string.Empty;
            this.Fecha =DateTime.Now;
            this.Lugar = string.Empty;
            this.Descripcion = string.Empty;
            this.Cantidad = 0;
            this.Precio = 0;

            this.Detalle = new List<PartidoDetalle>();
        }

        public Partido(int partidoid)
        {
            this.PartidoId = partidoid;
        }

        public void AgregarTickets(string descripcion, int cantidad, decimal precio)
        {
            this.Detalle.Add(new PartidoDetalle(descripcion, cantidad, precio));
        }
    }
}
