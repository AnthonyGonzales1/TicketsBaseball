using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Linq;
using System.Text;
using TicketsDeportivos.DAL;

namespace TicketsDeportivos.Entidades
{
    public class PartidoDetalle
    {
        [Key]
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Descripcion { get; set; }
        public int CantidadDisponible { get; set; }
        public int PrecioTicket { get; set; }

        public PartidoDetalle()
        {
            this.Id = 0;
        }

        public PartidoDetalle(int id, int ticketId, string descripcion, int cantidadDisponible, int precioTicket)
        {
            this.Id = id;
            this.TicketId = ticketId;
            this.Descripcion = descripcion;
            this.CantidadDisponible = cantidadDisponible;
            this.PrecioTicket = precioTicket;
        }
    }
}
