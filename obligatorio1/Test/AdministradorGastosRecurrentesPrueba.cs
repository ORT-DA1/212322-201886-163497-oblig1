using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Test
{
    [TestClass]
    public class AdministradorGastosRecurrentesPrueba
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private GastoRecuerrente unGastoRecuerrente;
        private Categoria unaCategoria;
        private Repositorio miRepositorio;

        [TestInitialize]
        public void InitTest()
        {
            miRepositorio = new Repositorio();
            adminGastosRecurrentes = new AdministradorGastosRecurrentes(miRepositorio);
            unGastoRecuerrente = new GastoRecuerrente();
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
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoRecuerrente.Categoria = unaCategoria;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            Assert.IsFalse(adminGastosRecurrentes.EsVaciaListaGastosRecurrentes());
        }

        [TestMethod]
        public void EliminarGastoRecurrentePrueba()
        {
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoRecuerrente.Categoria = unaCategoria;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            adminGastosRecurrentes.EliminarGastoRecurrente(unGastoRecuerrente);

            Assert.IsTrue(adminGastosRecurrentes.EsVaciaListaGastosRecurrentes());

        }


    }
}
