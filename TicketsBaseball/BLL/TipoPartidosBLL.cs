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
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) {
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
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) {
                throw;
            }

            return paso;
        }

        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                TipoPartido tipoPartido = contexto.TipoPartidos.Find(id);

                if (tipoPartido != null)
                {
                    contexto.Entry(tipoPartido).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }
            }
            catch (Exception) {
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
            catch (Exception) {
                throw;
            }
            return tipoPartido;
        }
        public static List<TipoPartido> GetList(Expression<Func<TipoPartido, bool>> expression)
        {
            List<TipoPartido> tipoPartido = new List<TipoPartido>();
            Contexto contexto = new Contexto();

            try
            {
                tipoPartido = contexto.TipoPartidos.Where(expression).ToList();
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
