using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Dominio;

namespace Test
{
    [TestClass]
    public class CategoriaMontoPrueba
    {
        private CategoriaMonto categoriaMonto;
        private Categoria categoria;



        [TestInitialize]
        public void InitTests()
        {
            categoriaMonto = new CategoriaMonto();
            categoria = new Categoria();
        }

        [TestMethod]
        public void PropertyCategoriaPrueba()
        {
            categoriaMonto.Categoria = categoria;

            Assert.AreEqual(categoria, categoriaMonto.Categoria);
        }

        [TestMethod]
        public void PropertyMontoPrueba()
        {
            categoriaMonto.Monto = 1000;
            int unMonto = 1000;
            Assert.AreEqual(categoriaMonto.Monto, unMonto);
        }

        [TestMethod]
        public void PropertyMontoDecimalPrueba()
        {


            categoriaMonto.Monto = 0;
            Assert.AreEqual(0.00, categoriaMonto.Monto);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void MontoMenorA0Prueba()
        {
            categoriaMonto.Monto = -1000.00;
        }

        
        [TestMethod]
        public void MontoInicialEn0Prueba()
        {
            int montoInicial = 0;
            Assert.AreEqual(montoInicial, categoriaMonto.Monto);

        }



    }
}