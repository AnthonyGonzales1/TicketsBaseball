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
        public int TicketId { get; set; }
        public string NombrePartido { get; set; }
        public DateTime FechaPartido { get; set; }
        public string LugarPartido { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDisponible { get; set; }
        public int PrecioTicket { get; set; }
        public List<PartidoDetalle> Detalle { get; set; }

        public Partido()
        {
            this.PartidoId = 0;
            this.TipoPartidoId = 0;
            this.TicketId = 0;
            this.NombrePartido = string.Empty;
            this.FechaPartido =DateTime.Now;
            this.LugarPartido = string.Empty;
            this.Descripcion = string.Empty;
            this.CantidadDisponible = 0;
            this.PrecioTicket = 0;

            this.Detalle = new List<PartidoDetalle>();
        }

        public Partido(int partidoid)
        {
            this.PartidoId = partidoid;
        }
    }
}
