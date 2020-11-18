
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Excepciones;

namespace Test
{
    [TestClass]
    public class MonedaPrueba
    {
        private Moneda moneda;

        [TestInitialize]
        public void InitTests()
        {
            moneda = new Moneda();
        }
        [TestMethod]
        public void PropertyNombrePrueba()
        {
            moneda.Nombre = "Euro";
            string nombre = "Euro";
            Assert.AreEqual(nombre, moneda.Nombre);
        }

        [TestMethod]
        public void PropertSimboloPrueba()
        {
            moneda.Simbolo = "$";
            string simbolo = "$";
            Assert.AreEqual(simbolo, moneda.Simbolo);
        }

        [TestMethod]
        public void PropertCotizacionPrueba()
        {
            moneda.Cotizacion = 58;
            double cotizacion = 58;
            Assert.AreEqual(cotizacion, moneda.Cotizacion);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionPalabraLarga))]
        public void LargoNombrePrueba()
        {
            moneda.Nombre = "Eu";

        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionPalabraLarga))]
        public void LargoSimboloPrueba()
        {
            moneda.Simbolo = "USDDD";
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void CotizacionMenor0Prueba()
        {
            moneda.Cotizacion = -3;
        }

        [TestMethod]
        public void ToStringMonedaPrueba()
        {

            Assert.AreEqual(moneda.ToString(), "UYU");

        }

        // La moneda por defecto es el ‘Peso
        //Uruguayo’, con símbolo ‘UYU’. Esta moneda debe estar disponible en el
        //sistema, sin necesidad de ingresarla manualmente, a la vez no se puede
        //modificar ni eliminar.

        //equals, constructor


    }
}
