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
    public class UsuarioBLL
    {
        public static bool Guardar(Usuario usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Usuarios.Add(usuario) != null)
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
                var eliminar = contexto.Usuarios.Find(Id);
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

        public static bool Modificar(Usuario usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;
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

        public static Usuario Buscar(int id)
        {
            Usuario usuario = new Usuario();
            Contexto contexto = new Contexto();
            try
            {
                usuario = contexto.Usuarios.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {

                throw;
            }
            return usuario;
        }

        public static List<Usuario> GetList(Expression<Func<Usuario, bool>> usua)
        {
            List<Usuario> usuarios = new List<Usuario>();
            Contexto contexto = new Contexto();
            try
            {
                usuarios = contexto.Usuarios.Where(usua).ToList();
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return usuarios;
        }
    }
}
