using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.DAL;
using System.Linq.Expressions;

namespace TicketsDeportivos.BLL
{
    public class PartidoDetalleBLL
    {
        public static List<PartidoDetalle> GetList(Expression<Func<PartidoDetalle, bool>> expression)
        {
            List<PartidoDetalle> partidoDetalle = new List<PartidoDetalle>();
            Contexto contexto = new Contexto();

            try
            {
                partidoDetalle = contexto.PartidoDetalles.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return partidoDetalle;
        }
    }
}
