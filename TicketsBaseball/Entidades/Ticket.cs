using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;

namespace TicketsDeportivos.Entidades
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public int PrecioTicket { get; set; }
        public string TipoPartidoId { get; set; }
        public string Descripcion { get; set; }

        public Ticket()
        {
            this.TicketId = 0;
            this.Descripcion = string.Empty;
            this.PrecioTicket = 0;
        }

        public Ticket(int ticketId, int precioTicket, string tipoPartidoId, string descripcion)
        {
            this.TicketId = ticketId;
            this.PrecioTicket = precioTicket;
            this.TipoPartidoId = tipoPartidoId;
            this.Descripcion = descripcion;
        }
    }
}
