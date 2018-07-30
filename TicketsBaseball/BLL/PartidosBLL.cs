using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.DAL;
using System.Data.Entity;
using System.Linq.Expressions;
using System.Data;

namespace TicketsDeportivos.BLL
{
    public class PartidoBLL
    {
        public static bool Guardar(Partido partido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Partidos.Add(partido) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
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
                Partido partido = contexto.Partidos.Find(id);

                if (partido != null)
                {
                    contexto.Entry(partido).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }
            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }
        
        public static bool Modificar(Partido partido)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(partido).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }

            return paso;
        }

        public static Partido Buscar(int id)
        {

            Partido partido = new Partido();
            Contexto contexto = new Contexto();

            try
            {
                partido = contexto.Partidos.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return partido;
        }
        
        public static List<Partido> GetList(Expression<Func<Partido, bool>> expression)
        {
            List<Partido> partido = new List<Partido>();
            Contexto contexto = new Contexto();

            try
            {
                partido = contexto.Partidos.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return partido;
        }
    }
}