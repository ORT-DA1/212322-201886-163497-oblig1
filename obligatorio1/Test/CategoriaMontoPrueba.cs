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
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void MontoMayorA0Prueba()
        {
            categoriaMonto.Monto = -1000;
        }

        //en repositorio: Cada vez que se crea una categoria se crea un objeto CategoriaMonto de esa categoria.
        [TestMethod]
        public void MontoInicialEn0Prueba()
        {
            int montoInicial = 0;
            Assert.AreEqual(montoInicial, categoriaMonto.Monto);

        }



    }
}