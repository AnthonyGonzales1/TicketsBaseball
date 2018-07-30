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
        private static Usuario usuario = new Usuario();
        public static bool Guardar(Usuario usuario)
        {
            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                if (contexto.Usuarios.Add(usuario) != null)
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

        public static bool Eliminar(int id)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                Usuario usuario = contexto.Usuarios.Find(id);

                if (usuario != null)
                {
                    contexto.Entry(usuario).State = EntityState.Deleted;
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



        public static bool Modificar(Usuario usuario)
        {

            bool paso = false;
            Contexto contexto = new Contexto();

            try
            {
                contexto.Entry(usuario).State = EntityState.Modified;

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
        
        public static List<Usuario> GetList(Expression<Func<Usuario, bool>> expression)
        {
            List<Usuario> usuario = new List<Usuario>();
            Contexto contexto = new Contexto();

            try
            {
                usuario = contexto.Usuarios.Where(expression).ToList();
                contexto.Dispose();

            }
            catch (Exception)
            {
                throw;
            }
            return usuario;
        }
        
        public static void LoginUsuario(string nombre, int id)
        {
            usuario.Nombres = nombre;
            usuario.UsuarioId = id;
        }


    }
}
