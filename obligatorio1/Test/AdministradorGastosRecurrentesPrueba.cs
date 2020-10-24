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
        [TestInitialize]
        public void InitTest()
        {
            adminGastosRecurrentes = new AdministradorGastosRecurrentes();
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
    }
}
