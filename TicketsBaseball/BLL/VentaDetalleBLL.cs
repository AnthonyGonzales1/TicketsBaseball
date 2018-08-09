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
    public class VentaDetalleBLL
    {
        public static bool Guardar(VentaDetalle ventaDetalle)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.VentaDetalles.Add(ventaDetalle) != null)
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
                var eliminar = contexto.VentaDetalles.Find(Id);
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

        public static bool Modificar(VentaDetalle ventaDetalle)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ventaDetalle).State = EntityState.Modified;
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

        public static VentaDetalle Buscar(int id)
        {
            VentaDetalle ventaDetalle = new VentaDetalle();
            Contexto contexto = new Contexto();
            try
            {

                ventaDetalle = contexto.VentaDetalles.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return ventaDetalle;
        }

        public static List<VentaDetalle> GetList(Expression<Func<VentaDetalle, bool>> ventadetalle)
        {
            List<VentaDetalle> ventaDetalles = new List<VentaDetalle>();
            Contexto contexto = new Contexto();
            try
            {
                ventaDetalles = contexto.VentaDetalles.Where(ventadetalle).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return ventaDetalles;
        }
    }
}
