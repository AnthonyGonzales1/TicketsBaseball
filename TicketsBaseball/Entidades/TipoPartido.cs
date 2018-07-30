using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketsDeportivos.Entidades
{
    public class TipoPartido
    {
        public int TipoPartidoId { get; set; }
        public string Descripcion { get; set; }

        public TipoPartido()
        {
            this.TipoPartidoId = 0;
            this.Descripcion = string.Empty;
        }

        public TipoPartido(int tipopartidoid, string descripcion)
        {
            this.TipoPartidoId = tipopartidoid;
            this.Descripcion = descripcion;
        }
    }
}
