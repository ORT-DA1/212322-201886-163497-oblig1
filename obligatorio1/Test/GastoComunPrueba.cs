using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class GastoComunPrueba
    {
        private GastoComun gasto;
        private Categoria cat;

        [TestInitialize]
        public void InitTests()
        {
            gasto = new GastoComun();
            cat = new Categoria();

        }

        [TestMethod]
        public void PropertyFechaPrueba()
        {
            gasto.Fecha = new DateTime(2020, 5, 1);
            DateTime fecha = new DateTime(2020, 5, 1);
            Assert.AreEqual(fecha, gasto.Fecha);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoInferiorFechaPrueba()
        {
            gasto.Fecha = new DateTime(2017, 12, 31);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoInferiorFechaGastoComunPrueba()
        {
            gasto.Fecha = new DateTime(2017, 12, 31);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoSuperiorFechaGastoComunPrueba()
        {
            gasto.Fecha = new DateTime(2031, 1, 1);

        }
        
        [TestMethod]
        public void ConstructorGastoComunPrueba()
        {
            DateTime fecha = new DateTime(2020, 5, 1);
            GastoComun gastoRec2 = new GastoComun(1000, "Ir a comer", cat,fecha);
            Assert.AreEqual(gastoRec2.Descripcion,"Ir a comer");

        }
        [TestMethod]
        public void ToStringGastoComunPrueba()
        {
            Assert.AreEqual(gasto.ToString(), "0,No hay descripcion,No hay nombre,1/5/2020 0:00:00");

        }


    }
}
