using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Test
{
    [TestClass]
    public class RepositorioPrueba
    {

        private Repositorio Repositorio { get; set; }
        private Categoria UnaCategoria { get; set; }
        private GastoRecuerrente GastoRecuerrente { get; set; }
        private GastoComun GastoComun { get; set; }


        [TestInitialize]
        public void InitTests()
        {
            Repositorio = new Repositorio();
            UnaCategoria = new Categoria();
            GastoRecuerrente = new GastoRecuerrente();
            GastoComun = new GastoComun();
        }

        [TestMethod]
        public void CrearListaCategoriasVaciaPrueba()
        {
            Assert.IsTrue(Repositorio.EsVaciaListaCategorias());
        }

        [TestMethod]
        public void RetornarListaCategoriasPrueba()
        {
            List<Categoria> ListaLocal = new List<Categoria>();
            Assert.IsTrue(Repositorio.RetornarListaCategorias().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        public void AlAgregarCateogoriaNoEsVacioPrueba()
        {
            Repositorio.AgregarCategoria(UnaCategoria);
            Assert.IsFalse(Repositorio.EsVaciaListaCategorias());
        }

        [TestMethod]
        public void EliminarCategoriaPrueba()
        {
            Repositorio.AgregarCategoria(UnaCategoria);
            Repositorio.EliminarCategoria(UnaCategoria);
            Assert.IsFalse(Repositorio.ExisteCategoria(UnaCategoria));
        }

        [TestMethod]
        public void ExisteCategoriaPrueba()
        {
            Repositorio.AgregarCategoria(UnaCategoria);
            Assert.IsTrue(Repositorio.ExisteCategoria(UnaCategoria));
        }



        [TestMethod]
        public void RetornarListaGastosRecurrentesPrueba()
        {
            List<GastoRecuerrente> ListaLocal = new List<GastoRecuerrente>();
            Assert.IsTrue(Repositorio.RetornarListaGastosRecurrentes().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        public void AlAgregarGastoRecuerrenteNoEsVacioPrueba()
        {
            Repositorio.AgregarGastoRecurrente(GastoRecuerrente);
            Assert.IsFalse(Repositorio.EsVaciaListaGastosRecurrentes());
        }

        [TestMethod]
        public void EliminarGastoRecuerrentePrueba()
        {
            Repositorio.AgregarGastoRecurrente(GastoRecuerrente);
            Repositorio.EliminarGastoRecuerrente(GastoRecuerrente);
            Assert.IsFalse(Repositorio.ExisteGastoRecurrente(GastoRecuerrente));

        }

        [TestMethod]
        public void ExisteGastoRecuerrentePrueba()
        {
            Repositorio.AgregarGastoRecurrente(GastoRecuerrente);
            Assert.IsTrue(Repositorio.ExisteGastoRecurrente(GastoRecuerrente));
        }




        [TestMethod]
        public void RetornarListaGastosComunesPrueba()
        {
            List<GastoComun> ListaLocal = new List<GastoComun>();
            Assert.IsTrue(Repositorio.RetornarListaGastosCoumnes().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        public void AlAgregarGastoComunNoEsVacioPrueba()
        {
            Repositorio.AgregarGastoComun(GastoComun);
            Assert.IsFalse(Repositorio.EsVaciaListaGastosComunes());
        }

        [TestMethod]
        public void EliminarGastoComunPrueba()
        {
            Repositorio.AgregarGastoComun(GastoComun);
            Repositorio.EliminarGastoComun(GastoComun);
            Assert.IsFalse(Repositorio.ExisteGastoComun(GastoComun));
        }

        [TestMethod]
        public void ExisteGastoComunPrueba()
        {
            Repositorio.AgregarGastoComun(GastoComun);
            Assert.IsTrue(Repositorio.ExisteGastoComun(GastoComun));
        }

        [TestMethod]
        public void RetornarListaMesesDondeHayGastoPrueba()
        {
            List<DateTime> ListaLocal = new List<DateTime>();
            Assert.IsTrue(Repositorio.RetornarListaMesesDondeHayGasto().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        public void AlAgregarMesesDondeHayGastoNoEsVacioPrueba()
        {
            GastoComun.Fecha = new DateTime(2020, 5, 1);
            Repositorio.AgregarMesDondeHayGasto(GastoComun.Fecha);
            Assert.IsFalse(Repositorio.EsVaciaListaMesesDondeHayGastos());
        }

        [TestMethod]
        public void ExisteMesPrueba()
        {
            Repositorio.AgregarMesDondeHayGasto(GastoComun.Fecha);
            Assert.IsTrue(Repositorio.ExisteMes(GastoComun.Fecha));
        }

        [TestMethod]
        public void CantidadMesesPrueba()
        {
            Repositorio.AgregarMesDondeHayGasto(GastoComun.Fecha);
            Repositorio.AgregarMesDondeHayGasto(GastoComun.Fecha);
            Assert.AreEqual(2, Repositorio.CantidadElementosEnListaMesesDondeHayGastos());
        }




    }
}
