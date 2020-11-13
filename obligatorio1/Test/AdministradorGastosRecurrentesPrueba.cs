using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;

namespace Test
{
    [TestClass]
    public class AdministradorGastosRecurrentesPrueba
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private GastoRecuerrente unGastoRecuerrente;
        private Categoria unaCategoria;
        private RepositorioMemoria miRepositorio;

        [TestInitialize]
        public void InitTest()
        {
            miRepositorio = new RepositorioMemoria();
            adminGastosRecurrentes = new AdministradorGastosRecurrentes(miRepositorio);
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoRecuerrente = new GastoRecuerrente() {Categoria = unaCategoria};
            unaCategoria = new Categoria();

        }

        [TestMethod]
        public void RetornarListaGastosRecurrentesPrueba()
        {

            List<GastoRecuerrente> ListaLocal = new List<GastoRecuerrente>();
            Assert.IsTrue(adminGastosRecurrentes.RetornarListaGastosRecurrentes().SequenceEqual(ListaLocal));

        }

        [TestMethod]
        public void AgregarGastoComunConCategoriaDefinidaPrueba()
        {
           
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            Assert.IsFalse(adminGastosRecurrentes.EsVaciaListaGastosRecurrentes());
        }

        [TestMethod]
        public void EliminarGastoRecurrentePrueba()
        {
            
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            adminGastosRecurrentes.EliminarGastoRecurrente(unGastoRecuerrente);

            Assert.IsTrue(adminGastosRecurrentes.EsVaciaListaGastosRecurrentes());

        }


    }
}
