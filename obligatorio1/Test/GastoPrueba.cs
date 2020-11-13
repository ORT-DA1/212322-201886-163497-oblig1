using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;


namespace Test
{
    
    [TestClass]
    public class GastoPrueba
    {
        private Gasto gasto;
        private Categoria cat;
        private Moneda moneda;

        [TestInitialize]
        public void InitTests()
        {
            gasto = new Gasto();
            cat = new Categoria();
            moneda = new Moneda();
        }

        [TestMethod]
        public void PropertyMonedaPrueba()
        {
            gasto.Moneda = moneda;
            moneda.Simbolo = "UYU";
            Assert.AreEqual(moneda.Simbolo, gasto.Moneda);
        }

        [TestMethod]
        public void PropertyMontoDecimalPrueba()
        {
            gasto.Monto = 0;
            Assert.AreEqual(0.00, gasto.Monto);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PropertyMontoPositivoPrueba()
        {
            gasto.Monto = -1;
        }

        [TestMethod]
        public void PropertyDescripcionPrueba()
        {
            gasto. Descripcion = "Una descripcion" ;
            string descrpcion = "Una descripcion";
            Assert.AreEqual(descrpcion, gasto.Descripcion);
        }

        [TestMethod]
        public void PropertyCategoriaPrueba()
        {
            Categoria cat = new Categoria();
            gasto.Categoria = cat ;
            Assert.AreEqual(cat , gasto.Categoria);
        }
        
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoDescripcionPrueba()
        {
            gasto.Descripcion = "a";
            Gasto gasto2 = new Gasto() { Descripcion = "abcdefghijklmnopqrsuvwxyz" };

        }

        [TestMethod]
        public void ConstructorPrueba()
        {
            Gasto gasto2 = new Gasto(1000, "Ir a comer", cat , moneda);
            Assert.AreEqual(gasto2.Monto,1000);
        }

       [TestMethod]
        public void ToStringGastoPrueba()
        {

            Assert.AreEqual(gasto.ToString(),"Monto: 0, Descripcion: No hay descripcion, Categoria: No hay nombre, Moneda: UYU");

        }


    }

}

  

