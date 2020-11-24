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
        private IRepositorio miRepositorio;
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        private GastoComun unGastoComun;
        private Categoria unaCategoria;
        private Categoria otraCategoria;
        private AdministradorPresupuesto adminPresupuesto;
        private GastoComun gasto;
        private Moneda moneda;
        

        [TestInitialize]
        public void InitTests()
        {
            miRepositorio = new RepositorioMemoria();
            adminGastosComunes = new AdministradorGastosComunes(miRepositorio);
            adminPresupuesto = new AdministradorPresupuesto(miRepositorio);
            adminCategorias = new AdministradorCategorias(miRepositorio);

            moneda = new Moneda { Simbolo = "UYU" };
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            otraCategoria = new Categoria() { Nombre = "Super" };
            gasto = new GastoComun() { Categoria = unaCategoria };
            unGastoComun = new GastoComun() { Categoria = unaCategoria, Moneda = moneda };

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
        public void EliminarGastoComunPrueba()
        {           
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            adminGastosComunes.EliminarGastoComun(unGastoComun);

            Assert.IsTrue(adminGastosComunes.EsVaciaListaGastosComunes());
        }
  /*      [TestMethod]
        public void ModificarGastoPrueba()
        {
            GastoComun gastoAntes = gasto;
            adminGastosComunes.AgregarGastoComun(gasto);
            adminGastosComunes.ModificarGasto(gasto);
            GastoComun gastoDespues = gasto;
            Assert.AreNotEqual(gastoAntes,gastoDespues);
        }*/
    }
}
