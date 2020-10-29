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

        [TestMethod]
        public void OrdenarListaMesesDondeHayGastoAnioPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 10, 1);
            GastoComun otroGasto = new GastoComun { Fecha = new DateTime(2018, 11, 1) };

            miRepositorio.AgregarMesDondeHayGasto(unGastoComun.Fecha);
            miRepositorio.AgregarMesDondeHayGasto(otroGasto.Fecha);


            Assert.AreEqual(adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada().First().Year, 2018);

        }

        [TestMethod]
        public void OrdenarListaDondeHayGastoOrdenDeMesesPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 10, 1);
            GastoComun unGasto = new GastoComun { Fecha = new DateTime(2020, 5, 1) };
            GastoComun otroGasto = new GastoComun { Fecha = new DateTime(2020, 6, 1) };

            miRepositorio.AgregarMesDondeHayGasto(unGastoComun.Fecha);
            miRepositorio.AgregarMesDondeHayGasto(unGasto.Fecha);
            miRepositorio.AgregarMesDondeHayGasto(otroGasto.Fecha);

            List<DateTime> ListaLocal = new List<DateTime>();
            ListaLocal.Add(new DateTime(2020, 5, 1));
            ListaLocal.Add(new DateTime(2020, 6, 1));
            ListaLocal.Add(new DateTime(2020, 10, 1));
            Assert.IsTrue(adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada().SequenceEqual(ListaLocal));

        }

        [TestMethod]
        public void AgregarListaDeMesesDondeHayGastoPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 10, 2);
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            Assert.AreEqual(1, adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada().Count());
        }

        [TestMethod]
        public void AgregarDosRepetidosListaDeMesesDondeHayGastoPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 10, 2);
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            GastoComun unGasto = new GastoComun { Categoria = unaCategoria, Fecha = new DateTime(2020, 10, 2) };
            adminGastosComunes.AgregarGastoComun(unGasto);
            Assert.AreEqual(1, adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada().Count());
        }


        [TestMethod]
        public void AgregarMesesAnioDondeHayGastoPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 10, 2);
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            adminReporteGastos.AgregarMesesAnioDondeHayGasto();
            Assert.AreEqual(1, adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada().Count());

        }
           
        [TestMethod]
        public void ConvertirFechaQuitarElDiaPrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 5, 28);
            DateTime convertido = adminReporteGastos.ConvertirFechaDejarSoloAnioMes(unGastoComun);
            Assert.IsFalse(convertido.Equals(unGastoComun.Fecha));
           
        }

        [TestMethod]
        public void CalcularMontoDeReportePrueba()
        {
            unGastoComun.Fecha = new DateTime(2020, 10, 28);
            unGastoComun.Monto = 100;
            GastoComun unGasto = new GastoComun { Categoria = unaCategoria, Monto = 100, Fecha = new DateTime(2020, 10, 2) };
            adminGastosComunes.AgregarGastoComun(unGastoComun);
            adminGastosComunes.AgregarGastoComun(unGasto);
            double resultado = 200;
            Assert.AreEqual(resultado, adminReporteGastos.CalcularMontoDeReporte(adminReporteGastos.UnirListaGastosDelMes(2020, 10)));

        }

        [TestMethod]
        public void CalcularGastoTotalDeCategoriaEnMesPrueba()
        {
            
            GastoComun unGasto = new GastoComun { Categoria = unaCategoria, Monto = 100, Fecha = new DateTime(2020, 10, 2) };
            GastoComun otroGasto = new GastoComun { Categoria = unaCategoria, Monto = 200, Fecha = new DateTime(2020, 10, 2) };
            adminGastosComunes.AgregarGastoComun(unGasto);
            adminGastosComunes.AgregarGastoComun(otroGasto);

            double gastoTotalDeCategoriaEnMes = adminReporteGastos.CalcularGastoTotalDeCategoriaEnMes(2020, 10, unaCategoria);

            Assert.AreEqual(gastoTotalDeCategoriaEnMes, 300);

        }




    }
}
