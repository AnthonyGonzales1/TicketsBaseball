using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketsDeportivos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.Entidades;
using System.Linq.Expressions;
using TicketsDeportivos.DAL;

namespace TicketsDeportivos.BLL.Tests
{
    [TestClass()]
    public class UsuarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Usuario usuario = new Usuario();
            usuario.UsuarioId = 3;
            usuario.Nombres = "Prueba";
            paso = UsuarioBLL.Guardar(usuario);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            bool paso;
            paso = UsuarioBLL.Eliminar(id);

            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Usuario usuario = new Usuario();
            usuario.UsuarioId = 3;
            usuario.Nombres = "Pruebasas";
           
            paso = UsuarioBLL.Modificar(usuario);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 3;
            Usuario usuario = new Usuario();
            usuario = UsuarioBLL.Buscar(id);
            Assert.IsNotNull(usuario);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Usuario, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Usuario> usuarios = new List<Usuario>();
            usuarios = contexto.Usuarios.Where(expression).ToList();
            Assert.IsNotNull(usuarios);
        }

        [TestMethod()]
        public void LoginUsuarioTest()
        {
        }
    }
}