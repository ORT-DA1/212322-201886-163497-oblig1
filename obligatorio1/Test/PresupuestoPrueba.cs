using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Globalization;
using Excepciones;
using Dominio;
using System.Linq;

namespace Test
{


    [TestClass]
    public class PresupuestoPrueba
    {
        private Presupuesto presupuesto;
        private Categoria categoria1;



        [TestInitialize]
        public void InitTests()
        {
            presupuesto = new Presupuesto();
            Categoria categoria1 = new Categoria() { Nombre = "Entretenimiento" };


        }
     

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoAnioPrueba()
        {
            presupuesto.Fecha = new DateTime(2070, 12, 31);
        }

        [TestMethod]
        public void CrearListaCategoriaMontoVaciaPrueba()
        {

            Assert.IsTrue(presupuesto.EsVaciaListaCategoriaMonto());

        }

        [TestMethod]
        public void AgregarCategoriaMontoPrueba()
        {
            presupuesto.AgregarCategoriaMonto(categoria1, 100);
            Assert.IsFalse(presupuesto.EsVaciaListaCategoriaMonto());
        }

       
        [TestMethod]
        public void ConstructorPresupuestoAsignarCategoriasExistentesPrueba() 
        {
            DateTime unaFecha = new DateTime(2020, 12, 31);
            Presupuesto presupuesto1 = new Presupuesto { Fecha = unaFecha};
            Assert.AreEqual(presupuesto1.Fecha, unaFecha);
        }

        [TestMethod]
        public void ToStringPrueba()
        {
            Assert.AreEqual(presupuesto.ToString(),"2020,5");
        }


        [TestMethod]
        public void ModificarMontoACategoriaPrueba()
        {

            presupuesto.AgregarCategoriaMonto(categoria1, 100);
            presupuesto.ModificarMontoACategoria(categoria1, 300);
            Assert.AreEqual(presupuesto.ListaCategoriaMonto.First().Monto , 300);

        }

    }
}
