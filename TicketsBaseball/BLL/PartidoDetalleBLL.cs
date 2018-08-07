using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.DAL;
using System.Linq.Expressions;
using System.Data.Entity;

namespace TicketsDeportivos.BLL
{
    public class PartidoDetalleBLL
    {
        public static bool Guardar(PartidoDetalle partidoDetalle)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.PartidoDetalles.Add(partidoDetalle) != null)
                {
                    contexto.SaveChanges();
                    contexto.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Eliminar(int Id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                var eliminar = contexto.PartidoDetalles.Find(Id);
                if (eliminar != null)
                {
                    contexto.Entry(eliminar).State = EntityState.Deleted;
                    if (contexto.SaveChanges() > 0)
                    {
                        contexto.Dispose();
                        paso = true;
                    }
                }

            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }

        public static bool Modificar(PartidoDetalle partidoDetalle)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(partidoDetalle).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    contexto.Dispose();
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static PartidoDetalle Buscar(int id)
        {
            PartidoDetalle partidoDetalle = new PartidoDetalle();
            Contexto contexto = new Contexto();
            try
            {

                partidoDetalle = contexto.PartidoDetalles.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return partidoDetalle;
        }

        public static List<PartidoDetalle> GetList(Expression<Func<PartidoDetalle, bool>> partidodetalle)
        {
            List<PartidoDetalle> partidoDetalles = new List<PartidoDetalle>();
            Contexto contexto = new Contexto();
            try
            {
                partidoDetalles = contexto.PartidoDetalles.Where(partidodetalle).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return partidoDetalles;
        }
    }
}
