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
    public class VentaDetalle
    {
        [Key]
        public string UsuarioId { get; set; }
        public string PartidoId { get; set; }
        public int Ticket { get; set; }
        public int Total { get; set; }
        public DateTime Fecha { get; set; }

        public VentaDetalle()
        {
        }

        public VentaDetalle(string usuarioId, string PartidoId, int ticket, int total, DateTime fecha)
        {
            this.UsuarioId = usuarioId;
            this.PartidoId = PartidoId;
            this.Ticket = ticket;
            this.Total = total;
            this.Fecha = fecha;
        }
    }
}
