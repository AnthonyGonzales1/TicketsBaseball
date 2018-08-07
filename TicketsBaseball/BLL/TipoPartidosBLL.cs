using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using TicketsDeportivos.DAL;
using TicketsDeportivos.Entidades;

namespace TicketsDeportivos.BLL
{
    public class TipoPartidosBLL
    {
        public static bool Guardar(TipoPartido tipoPartido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.TipoPartidos.Add(tipoPartido) != null)
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
                var eliminar = contexto.TipoPartidos.Find(Id);
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

        public static bool Modificar(TipoPartido tipoPartido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(tipoPartido).State = EntityState.Modified;
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

        public static TipoPartido Buscar(int id)
        {
            TipoPartido tipoPartido = new TipoPartido();
            Contexto contexto = new Contexto();
            try
            {

                tipoPartido = contexto.TipoPartidos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return tipoPartido;
        }

        public static List<TipoPartido> GetList(Expression<Func<TipoPartido, bool>> tipopartido)
        {
            List<TipoPartido> tipoPartido = new List<TipoPartido>();
            Contexto contexto = new Contexto();
            try
            {
                tipoPartido = contexto.TipoPartidos.Where(tipopartido).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return tipoPartido;
        }
    }
}
