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

        [TestInitialize]
        public void InitTests()
        {
            Repositorio = new Repositorio();
            UnaCategoria = new Categoria();
            GastoRecuerrente = new GastoRecuerrente();

        }

        [TestMethod]
        public void CrearListaCategoriasVaciaPrueba()
        {
            Assert.IsTrue(Repositorio.EsVaciaListaCategorias());

        }

        // METODO NUEVO PARA PROBAR EL RETORNAR LISTACAT
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

        // Pruebas nuevas 
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









    }
}
