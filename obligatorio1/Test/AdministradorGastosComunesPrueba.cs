using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using Excepciones;


namespace Test
{
    [TestClass]
    public class AdministradorGastosComunesPrueba
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        private GastoComun unGastoComun;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            adminGastosComunes = new AdministradorGastosComunes();
            adminCategorias = new AdministradorCategorias();
            unGastoComun = new GastoComun();
            unaCategoria = new Categoria();

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
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoComun.Categoria = unaCategoria;
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
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoComun.Categoria = unaCategoria;
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            adminGastosComunes.EliminarGastoComun(unGastoComun);

            Assert.IsTrue(adminGastosComunes.EsVaciaListaGastosComunes());

        }


        [TestMethod]
        public void DevolverListaDeGastosSegunFechaPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 5, 1);
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            List<GastoComun> ListaLocal = new List<GastoComun>();
            ListaLocal.Add(unGastoComun);
            Assert.IsTrue(adminGastosComunes.DevolverListaDeGastosSegunFecha(unGastoComun.Fecha).SequenceEqual(ListaLocal));

        }


     }
}
