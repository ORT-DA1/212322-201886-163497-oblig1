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
        private GastoComun unGastoComun;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            adminGastosComunes = new AdministradorGastosComunes();
            unGastoComun = new GastoComun();
            unaCategoria = new Categoria();
            unaCategoria.Nombre = "Entretenimiento";
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

    }
}
