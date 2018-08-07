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
                var eliminar = contexto.Ventas.Find(Id);
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

        public static bool Modificar(Venta venta)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(venta).State = EntityState.Modified;
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

        public static Venta Buscar(int id)
        {
            Venta venta = new Venta();
            Contexto contexto = new Contexto();
            try
            {
                venta = contexto.Ventas.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return venta;
        }

        public static List<Venta> GetList(Expression<Func<Venta, bool>> vent)
        {
            List<Venta> ventas = new List<Venta>();
            Contexto contexto = new Contexto();
            try
            {
                ventas = contexto.Ventas.Where(vent).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return ventas;
        }
    }
}
