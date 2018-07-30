using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketsDeportivos.DAL;

namespace TicketsDeportivos.Entidades
{
    public class Venta
    {
        public int VentaId { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Fecha { get; set; }
        public int Ticket { get; set; }
        public int Cantidad { get; set; }
        public string Descripcion { get; set; }
        public decimal Total { get; set; }

        public List<Partido> Ventapartido { get; set; }

        public Venta()
        {
            this.VentaId = 0;
            this.UsuarioId = 0;
            this.Fecha = DateTime.Now;
            this.Ticket = 0;
            this.Cantidad = 0;
            this.Descripcion = string.Empty;
            this.Total = 0;
            this.Ventapartido = new List<Partido>();
        }

        public Venta(int ventaid, int usuarioid, DateTime fecha, int ticket, string descripcion, int cantidad, decimal total)
        {
            this.VentaId = ventaid;
            this.UsuarioId = usuarioid;
            this.Fecha = fecha;
            this.Ticket = ticket;
            this.Cantidad = cantidad;
            this.Descripcion = descripcion;
            this.Total = total;
        }

        public void AgregarVenta(int EventoId)
        {
            this.Ventapartido.Add(new Partido(EventoId));
        }
    }
}