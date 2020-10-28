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
        public void PropertyMesPrueba()
        {
           
            string nombreMes = "enero";
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
            presupuesto.AgregarCategoriaMonto(categoria1, 100);
            Assert.IsFalse(presupuesto.EsVaciaListaCategoriaMonto());
        }

       /* [TestMethod]
        public void ConstructorPresupuestoPrueba()
        {
            Presupuesto presupuesto1 = new Presupuesto(2019, "Setiembre");
            Assert.AreEqual(presupuesto1.Anio, 2019);

        }*/
        [TestMethod]
        public void ConstructorPresupuestoAsignarCategoriasExistentesPrueba() 
 //hacer prueba que verifica que la lista de CategoriaMonto, (constr por defecto), sean todas las categorias existentes, y monto 0.
 //verificar tambien en categoria que cada vez que se crea una, crear objeto CategoriaMonto para todos los presupuestos, con monto 0.
        {
            Presupuesto presupuesto1 = new Presupuesto { Anio=2019, Mes= "Setiembre"};
            Assert.AreEqual(presupuesto1.Anio, 2019);

        }

        [TestMethod]
        public void ToStringPrueba()
        {
            Assert.AreEqual(presupuesto.ToString(),"2019,Setiembre");
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
