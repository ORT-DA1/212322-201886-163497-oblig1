using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using Dominio;
using Excepciones;

namespace Test
{

    /*
     *Alta y Modificación de Presupuesto: Esta opción permite establecer el
presupuesto para un mes particular. Es decir que se introduce el monto
planificado a gastar en cada categoría durante el mes elegido. El mes se
selecciona de una lista de posibilidades. El anio es un entero entre 2018 y
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
            presupuesto.Mes = "enero";

            Assert.AreEqual(nombreMes, presupuesto.Mes);

        }

        [TestMethod]
        public void PropertyAnioPrueba()
        {
            int anio = 2019;
            presupuesto.Anio = 2019;

            Assert.AreEqual(anio, presupuesto.Anio);
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionFueraDeFecha))]
        public void RangoAnioPrueba()
        {
            
            presupuesto.Anio = 2031;

        }

        [TestMethod]
        public void CrearListaCategoriaMontoVaciaPrueba()
        {

            Assert.IsTrue(presupuesto.EsVaciaListaCategoriaMonto());

        }

        [TestMethod]
        public void AgregarCategoriaMontoPrueba()
        {
            CategoriaMonto categoriaMonto = new CategoriaMonto();
            presupuesto.AgregarCategoriaMonto(categoriaMonto);

            Assert.IsFalse(presupuesto.EsVaciaListaCategoriaMonto());
        }

        [TestMethod]
        public void ConstructorPresupuestoPrueba()
        {
            Presupuesto presupuesto1 = new Presupuesto(2019, "Setiembre");
            Assert.AreEqual(presupuesto1.Anio, 2019);

        }

        [TestMethod]
        public void ToStringPrueba()
        {
            Assert.AreEqual(presupuesto.ToString(),"2019,Setiembre");
        }

    }
}
