using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace TicketsDeportivos.Entidades
{
    public class Ticket
    {
        [Key]
        public int TicketId { get; set; }
        public string Descripcion { get; set; }
        public int PrecioTicket { get; set; }

        public Ticket()
        {
            this.TicketId = 0;
            this.Descripcion = string.Empty;
            this.PrecioTicket = 0;
        }

        public Ticket(int ticketId)
        {
            this.TicketId = ticketId;
        }
    }
}
