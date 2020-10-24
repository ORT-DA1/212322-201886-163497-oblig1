using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class AdministradorPresupuestoPrueba
    {
        
        private AdministradorPresupuesto adminPresupuestos;
        private AdministradorCategorias adminCategorias;
        private GastoComun unGastoComun;
        private Categoria unaCategoria;
        private Presupuesto unPresupuesto;

        [TestInitialize]
        public void InitTests()
        {
            adminPresupuestos = new AdministradorPresupuesto();
            adminCategorias = new AdministradorCategorias();
            unGastoComun = new GastoComun();
            unaCategoria = new Categoria();
            unPresupuesto = new Presupuesto();
        }

        [TestMethod]
        public void RetornarListaPresupuestoPrueba()
        {
            List<Presupuesto> ListaLocal = new List<Presupuesto>();
            Assert.IsTrue(adminPresupuestos.RetornarListaPresupuestos().SequenceEqual(ListaLocal));
        }
        
       
        [TestMethod]
        public void AgregarPresupuestoPrueba()
        {
            adminPresupuestos.AgregarPresupuesto(unPresupuesto);
            List<Presupuesto> ListaLocal = new List<Presupuesto>();
            ListaLocal.Add(unPresupuesto);
            Assert.IsTrue(adminPresupuestos.RetornarListaPresupuestos().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        public void RetornarPresupuestoSegunMesPrueba()
        {
            unPresupuesto.Anio = 2020;
            unPresupuesto.Mes = "Marzo";
            adminPresupuestos.AgregarPresupuesto(unPresupuesto);
            Assert.AreEqual(adminPresupuestos.RetornarPresupuestoSegunMes("Marzo", 2020), unPresupuesto);
        }

        /*
        [TestMethod]
        public void ActualizarPresupuestosConNuevaCategoriaPrueba()
        {
            adminCategorias.AgregarCategoria(unaCategoria); //ahi se crea el categoriaMonto con esa categoria para todas los presupuestos
                                                            //dado un int anio y un string mes, retornar presupuesto:

//si se agrega una categoria, se tendrian que actualizar todos los categoria montos
            CategoriaMonto catMontoNuevo = new CategoriaMonto { Categoria = unaCategoria, Monto = 0 };
            Assert.IsTrue( adminPresupuestos.RetornarPresupuestoSegunMes("Marzo", 2008).ListaCategoriaMonto.Contains(catMontoNuevo));

        }
        */

        //dada una categoria, asignar monto.
        /*
        [TestMethod]
        public void ModificarMontoDeCategoriaAPresupuestoPrueba()
        {
            adminCategorias.AgregarCategoria(unaCategoria); //ahi se crea el categoriaMonto con esa categoria para todas los presupuestos
            adminPresupuestos.ModificarMontoACategoria(unPresupuesto, unaCategoria, 200);
            Assert
            

        }
        */
        //metodo que a un presupuesto, le deje cambiar el monto de esa categoria.



    }
}
