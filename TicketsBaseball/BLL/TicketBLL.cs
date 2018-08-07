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
    public class TicketBLL
    {
        public static bool Guardar(Ticket ticket)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Tickets.Add(ticket) != null)
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
                var eliminar = contexto.Tickets.Find(Id);
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

        public static bool Modificar(Ticket ticket)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ticket).State = EntityState.Modified;
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

        public static Ticket Buscar(int id)
        {
            Ticket ticket = new Ticket();
            Contexto contexto = new Contexto();
            try
            {

                ticket = contexto.Tickets.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return ticket;
        }

        public static List<Ticket> GetList(Expression<Func<Ticket, bool>> tic)
        {
            List<Ticket> tickets = new List<Ticket>();
            Contexto contexto = new Contexto();
            try
            {
                tickets = contexto.Tickets.Where(tic).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return tickets;
        }
    }
}
