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
    public class VentasBLL
    {
        public static bool Guardar(Venta venta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Ventas.Add(venta) != null)
                {
                    contexto.SaveChanges();
                    paso = true;
                }
                contexto.Dispose();

            }
            catch (Exception) { throw; }

            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Venta venta = contexto.Ventas.Find(id);

                if (venta != null)
                {
                    contexto.Entry(venta).State = EntityState.Deleted;
                }

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                    contexto.Dispose();
                }
            }
            catch (Exception) { throw; }

            return paso;
        }
        
        public static bool Modificar(Venta venta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(venta).State = EntityState.Modified;

                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception) { throw; }

            return paso;
        }

        public static Venta Buscar(int id)
        {
            Venta venta = new Venta();
            Contexto contexto = new Contexto();

            try
            {
                venta = contexto.Ventas.Find(id);
                contexto.Dispose();
            }
            catch (Exception) {
                throw;
            }
            return venta;
        }
        
        public static List<Venta> GetList(Expression<Func<Venta, bool>> expression)
        {
            List<Venta> venta = new List<Venta>();
            Contexto contexto = new Contexto();

            try
            {
                venta = contexto.Ventas.Where(expression).ToList();
                contexto.Dispose();
            }
            catch (Exception) {
                throw;
            }
            return venta;
        }
    }
}
