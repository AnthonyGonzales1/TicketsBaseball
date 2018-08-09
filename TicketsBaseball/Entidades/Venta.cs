using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsDeportivos.DAL;

namespace TicketsDeportivos.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public string UsuarioId { get; set; }
        public string PartidoId { get; set; }
        public int Ticket { get; set; }
        public DateTime Fecha { get; set; }
        public int CantidadDisponible { get; set; }
        public string Descripcion { get; set; }
        public int Total { get; set; }

        public List<VentaDetalle> Detalle { get; set; }

        public Venta()
        {
            this.VentaId = 0;
            this.UsuarioId = string.Empty;
            this.PartidoId = string.Empty;
            this.Ticket = 0;
            this.Fecha = DateTime.Now;
            this.CantidadDisponible = 0;
            this.Descripcion = string.Empty;
            this.Total = 0;


            this.Detalle = new List<VentaDetalle>();
        }

        public Venta(int ventaid, string usuarioid, string partidoId, int ticket, DateTime fecha, int cantidadDisponible, string descripcion, int total)
        {
            this.VentaId = ventaid;
            this.UsuarioId = usuarioid;
            this.PartidoId = partidoId;
            this.Ticket = ticket;
            this.Fecha = fecha;
            this.CantidadDisponible = cantidadDisponible;
            this.Descripcion = descripcion;
            this.Total = total;
        }
    }
}