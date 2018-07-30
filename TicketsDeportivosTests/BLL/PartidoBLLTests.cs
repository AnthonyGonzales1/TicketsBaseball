using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketsDeportivos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.Entidades;
using TicketsDeportivos.DAL;
using System.Linq.Expressions;

namespace TicketsDeportivos.BLL.Tests
{
    [TestClass()]
    public class PartidoBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            Partido partido = new Partido();
            partido.PartidoId = 3;
            partido.Nombre = "Prueba";
            partido.Cantidad = 10;
            paso = PartidoBLL.Guardar(partido);

            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            bool paso;
            paso = PartidoBLL.Eliminar(id);
           
            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            Partido partido = new Partido();
            partido.PartidoId = 3;
            partido.Nombre = "Prueba";
            partido.Cantidad = 8;
            paso = PartidoBLL.Modificar(partido);

            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 3;
            Partido partido = new Partido();
            partido = PartidoBLL.Buscar(id);
            Assert.IsNotNull(partido);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<Partido, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<Partido> partidos = new List<Partido>();
            partidos = contexto.Partidos.Where(expression).ToList();
            Assert.IsNotNull(partidos);
        }
    }
}