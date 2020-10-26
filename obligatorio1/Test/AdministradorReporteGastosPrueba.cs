using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    [TestClass]
    public class AdministradorReporteGastosPrueba
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private GastoRecuerrente unGastoRecuerrente;
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorReporteGastos adminReporteGastos;
        private Categoria unaCategoria;
        private Repositorio miRepositorio;
        private GastoComun unGastoComun;

        [TestInitialize]
        public void InitTest()
        {
            miRepositorio = new Repositorio();
            adminGastosRecurrentes = new AdministradorGastosRecurrentes(miRepositorio);
            adminGastosComunes = new AdministradorGastosComunes(miRepositorio);
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoRecuerrente = new GastoRecuerrente() { Categoria = unaCategoria };
            unGastoComun = new GastoComun() { Categoria = unaCategoria };
            adminReporteGastos = new AdministradorReporteGastos(miRepositorio);


        }


        [TestMethod]
        public void ConvertirGastoRecurrenteMesPrueba()
        {

            unGastoComun = new GastoComun { Categoria = unaCategoria };
            unGastoComun = adminReporteGastos.ConvertirGastoRecurrente(unGastoRecuerrente, 2020, 5);
            Assert.AreEqual(unGastoComun.Fecha.Month, 5);

        }


        [TestMethod]
        public void ConvertirGastoRecurrenteAnioPrueba()
        {

            unGastoComun = new GastoComun { Categoria = unaCategoria };
            Assert.AreEqual(adminReporteGastos.ConvertirGastoRecurrente(unGastoRecuerrente, 2020, 5).Fecha.Year, 2020);

        }


       /* [TestMethod]
        public void RetornarListaGastosRecurrentesConFechaAdecuadaPrueba()
        {

            unGastoRecuerrente.Fecha = 1;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);

            List<GastoComun> listaLocal = new List<GastoComun>();
            GastoComun otroGastoComun = new GastoComun { Categoria = unaCategoria };
            otroGastoComun.Fecha = new DateTime(2020, 10, 1);
            listaLocal.Add(otroGastoComun);

            Assert.IsTrue(adminReporteGastos.RetornarListaGastosRecurrentesConFechaAdecuada(2020, 10).SequenceEqual(listaLocal));

        }*/
        [TestMethod]
        public void ElementosEnListaGastosRecurrentesConFechaAdecuadaPrueba()
        {
            unGastoRecuerrente.Fecha = 1;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            Assert.AreEqual(1, adminReporteGastos.RetornarListaGastosRecurrentesConFechaAdecuada(2020, 10).Count());


        }

        [TestMethod]

        public void DevolverListaDeGastosSegunFechaPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 5, 1);
            adminGastosComunes.AgregarGastoComun(unGastoComun);

            GastoComun otroGasto = new GastoComun() { Fecha = new DateTime(2020, 6, 1) };
            otroGasto.Categoria = new Categoria { Nombre = "Auto" };
            adminGastosComunes.AgregarGastoComun(otroGasto);

            List<GastoComun> ListaLocal = new List<GastoComun>();
            ListaLocal.Add(otroGasto);
            Assert.IsTrue(adminReporteGastos.DevolverListaDeGastosComunesSegunFecha(2020,6).SequenceEqual(ListaLocal));

        }
        [TestMethod]

        public void UnirListaGastosDelMesPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 5, 1);
            adminGastosComunes.AgregarGastoComun(unGastoComun);

            unGastoRecuerrente.Fecha = 1;
            adminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecuerrente);
            Assert.AreEqual(2, adminReporteGastos.UnirListaGastosDelMes(2020, 5).Count());


        }



    }
}
