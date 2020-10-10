using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using obligatorio1;

namespace Test
{

    /*
     *Alta y Modificación de Presupuesto: Esta opción permite establecer el
presupuesto para un mes particular. Es decir que se introduce el monto
planificado a gastar en cada categoría durante el mes elegido. El mes se
selecciona de una lista de posibilidades. El año es un entero entre 2018 y
2030. En la modificación no se puede cambiar el mes, pero sí el monto de
una o varias categorías. Si se agrega una categoría luego de haber creado el
presupuesto, el valor para la categoría nueva será inicialmente cero,
pudiendo el usuario cambiarlo después. Los montos por categoría son
números positivos positivos, con dos decimales.

     * 
     */

    [TestClass]
    public class PresupuestoPrueba
    {
        private Presupuesto presupuesto;

        [TestInitialize]
        public void InitTests()
        {
            presupuesto = new Presupuesto();

        }

        [TestMethod]
        public void PropertyMesPrueba()
        {

            string nombreMes = DateTimeFormatInfo.CurrentInfo.GetMonthName(1);
            presupuesto.mes = "January";

            Assert.AreEqual(nombreMes, presupuesto.mes);

        }

        [TestMethod]
        public void PropertyMontoPrueba()
        {
            int monto = 200;
            presupuesto.monto = 200;

            Assert.AreEqual(monto, presupuesto.monto);
        }

        [TestMethod]
        public void PropertyAño()
        {
            int año = 2019;
            presupuesto.Año = 2019;

            Assert.AreEqual(año, presupuesto.Año);
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoAñoPrueba()
        {
            //Presupuesto presupuesto1 = new Presupuesto() { Año = 2031 };
            presupuesto.Año = 2031;
        }


    }
}
