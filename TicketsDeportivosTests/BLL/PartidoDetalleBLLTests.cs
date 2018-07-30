using Microsoft.VisualStudio.TestTools.UnitTesting;
using TicketsDeportivos.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TicketsDeportivos.DAL;
using System.Linq.Expressions;
using TicketsDeportivos.Entidades;

namespace TicketsDeportivos.BLL.Tests
{
    [TestClass()]
    public class PartidoDetalleBLLTests
    {
        [TestMethod()]
        public void GetListTest(Expression<Func<PartidoDetalle, bool>> expression)
        {
            Contexto contexto = new Contexto();

            List<PartidoDetalle> partidoDetalles = new List<PartidoDetalle>();
            partidoDetalles = contexto.PartidoDetalles.Where(expression).ToList();
            Assert.IsNotNull(partidoDetalles);
        }
    }
}