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
    public class TipoPartidosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso;
            TipoPartido tipoPartido = new TipoPartido();
            tipoPartido.TipoPartidoId = 3;
            tipoPartido.Descripcion = "Prueba";
            paso = TipoPartidosBLL.Guardar(tipoPartido);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            bool paso;
            TipoPartido tipoPartido = new TipoPartido();
            tipoPartido.TipoPartidoId = 3;
            tipoPartido.Descripcion = "Pruebas";
            paso = TipoPartidosBLL.Modificar(tipoPartido);

            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 3;
            bool paso;
            paso = TipoPartidosBLL.Eliminar(id);

            Assert.AreEqual(paso, false);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            int id = 3;
            TipoPartido tipoPartido = new TipoPartido();
            tipoPartido = TipoPartidosBLL.Buscar(id);
            Assert.IsNotNull(tipoPartido);
        }

        [TestMethod()]
        public void GetListTest(Expression<Func<TipoPartido, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<TipoPartido> tipoPartidos = new List<TipoPartido>();
            tipoPartidos = contexto.TipoPartidos.Where(expression).ToList();
            Assert.IsNotNull(tipoPartidos);
        }
    }
}