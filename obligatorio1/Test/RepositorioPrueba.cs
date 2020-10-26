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

        // PRUEBAS DE LISTA CATEGORIAS
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

        // PRUEBAS DE LISTA GASTOS RECURRENTES
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


        // PRUEBAS DE LISTA GASTOS COMUNES

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

        // PRUEBAS DE LISTA DE MESES
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

        [TestMethod]
        public void OrdenarListaMesesDondeHayGastoAnioPrueba()
        {
            GastoComun.Fecha = new DateTime(2020, 10, 1);
            GastoComun otroGasto = new GastoComun { Fecha = new DateTime(2018, 11, 1) };
            
            Repositorio.AgregarMesDondeHayGasto(GastoComun.Fecha);
            Repositorio.AgregarMesDondeHayGasto(otroGasto.Fecha);
           
            
            Assert.AreEqual(Repositorio.RetornarOrdenadaListaMesesDondeHayGasto().First().Year, 2018);

        }

        [TestMethod]
        public void OrdenarListaDondeHayGastoOrdenDeMesesPrueba()
        {
            GastoComun.Fecha = new DateTime(2020, 10, 1);
            GastoComun unGasto = new GastoComun { Fecha = new DateTime(2020, 5, 1) };
            GastoComun otroGasto = new GastoComun { Fecha = new DateTime(2020, 6, 1) };

            Repositorio.AgregarMesDondeHayGasto(GastoComun.Fecha);
            Repositorio.AgregarMesDondeHayGasto(unGasto.Fecha);
            Repositorio.AgregarMesDondeHayGasto(otroGasto.Fecha);

             List<DateTime> ListaLocal = new List<DateTime>();
            ListaLocal.Add(new DateTime(2020, 5, 1));
            ListaLocal.Add(new DateTime(2020, 6, 1));
            ListaLocal.Add(new DateTime(2020, 10, 1));
            Assert.IsTrue(Repositorio.RetornarOrdenadaListaMesesDondeHayGasto().SequenceEqual(ListaLocal));
            

        }



    }
}
