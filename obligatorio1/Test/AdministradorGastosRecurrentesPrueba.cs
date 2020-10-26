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
        private GastoComun unGastoComun;

        [TestInitialize]
        public void InitTest()
        {
            miRepositorio = new Repositorio();
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

        [TestMethod]
        public void ConvertirGastoRecurrenteMesPrueba()
        {
           
            unGastoComun = new GastoComun { Categoria = unaCategoria };
            unGastoComun = adminGastosRecurrentes.ConvertirGastoRecurrente(unGastoRecuerrente, 2020, 5);
            Assert.AreEqual(unGastoComun.Fecha.Month, 5);

        }


        [TestMethod]
        public void ConvertirGastoRecurrenteAnioPrueba()
        {
           
            unGastoComun = new GastoComun { Categoria = unaCategoria };
            Assert.AreEqual(adminGastosRecurrentes.ConvertirGastoRecurrente(unGastoRecuerrente, 2020, 5).Fecha.Year, 2020);

        }


        [TestMethod]
        public void RetornarListaGastosRecurrentesConFechaAdecuadaPrueba()
        {
           
            unGastoRecuerrente.Fecha = 1;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);

            List<GastoComun> listaLocal = new List<GastoComun>();
            GastoComun otroGastoComun = new GastoComun {Categoria = unaCategoria};
            otroGastoComun.Fecha = new DateTime(2020, 10, 1);
            listaLocal.Add(otroGastoComun);

            Assert.IsTrue(adminGastosRecurrentes.RetornarListaGastosRecurrentesConFechaAdecuada(2020, 10).SequenceEqual(listaLocal));

        }
        [TestMethod]
        public void ElementosEnListaGastosRecurrentesConFechaAdecuadaPrueba()
        {
            unGastoRecuerrente.Fecha = 1;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            Assert.AreEqual(1, adminGastosRecurrentes.RetornarListaGastosRecurrentesConFechaAdecuada(2020, 10).Count());
            

        }






    }
}
