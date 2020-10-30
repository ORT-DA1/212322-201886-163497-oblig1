using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using Excepciones;


namespace Test
{
    [TestClass]
    public class AdministradorGastosComunesPrueba
    {
        private Repositorio miRepositorio;
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        private GastoComun unGastoComun;
        private Categoria unaCategoria;
        private AdministradorPresupuesto adminPresupuesto;

        [TestInitialize]
        public void InitTests()
        {
            miRepositorio = new Repositorio();
            adminGastosComunes = new AdministradorGastosComunes(miRepositorio);
            adminPresupuesto = new AdministradorPresupuesto(miRepositorio);
            adminCategorias = new AdministradorCategorias(miRepositorio);
            
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoComun = new GastoComun() { Categoria = unaCategoria};
        }

        [TestMethod]
        public void RetornarListaGastosComunes()
        {
            List<GastoComun> ListaLocal = new List<GastoComun>();
            Assert.IsTrue(adminGastosComunes.RetornarListaGastosComunes().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        public void AgregarGastoComunConCategoriaDefinidaPrueba()
        {
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            Assert.IsFalse(adminGastosComunes.EsVaciaListaGastosComunes());
        }

        [TestMethod]
        public void EsVaciaListaGastosComunes()
        {
            Assert.IsTrue(adminGastosComunes.EsVaciaListaGastosComunes());
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoNoExistente))]
        public void AgregarGastoComunConCategoriaVaciaPrueba()
        {
            GastoComun otroGastoComun = new GastoComun();
            adminGastosComunes.AgregarGastoComun(otroGastoComun);

        }

        [TestMethod]
        public void EliminarGastoComunPrueba()
        {           
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            adminGastosComunes.EliminarGastoComun(unGastoComun);

            Assert.IsTrue(adminGastosComunes.EsVaciaListaGastosComunes());

        }


    }
}
