using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public int PartidoId { get; set; }

        public string Descripcion { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }

        public PartidoDetalle()
        {
            this.Id = 0;
            this.PartidoId = 0;
            this.Descripcion = string.Empty;
            this.Cantidad = 0;
            this.Precio = 0;
        }

        public PartidoDetalle(string descripcion, int cantidad, decimal precio)
        {
            this.Descripcion = descripcion;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }
}
