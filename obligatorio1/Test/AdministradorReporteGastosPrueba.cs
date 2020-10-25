using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Collections.Generic;
using System;
using Dominio;

namespace Test
{
    [TestClass]
    public class AdministradorReporteGastosPrueba
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorReporteGastos adminReporteGastos;
        private Repositorio repositorio;
        private GastoComun unGastoComun;
        private Categoria unaCategoria;
        private GastoRecuerrente unGRecurrente;
        private AdministradorGastosRecurrentes adminGRecurrentes;


        [TestInitialize]
        public void InitTests()
        {
            adminGastosComunes = new AdministradorGastosComunes();
            adminReporteGastos = new AdministradorReporteGastos();
            repositorio = new Repositorio();
            unaCategoria = new Categoria() { Nombre = "Entretenimiento" };
            unGastoComun = new GastoComun();
            unGastoComun.Categoria = unaCategoria;
            unGRecurrente = new GastoRecuerrente();
            adminGRecurrentes = new AdministradorGastosRecurrentes();
        }


        [TestMethod]
        public void RetornarListaGastosRecurrentesYComunes()
        {
            unGastoComun.Fecha = new DateTime(2020, 5, 1);
            adminGastosComunes.AgregarGastoComun(unGastoComun);

            adminGRecurrentes.AgregarGastoRecurrente(unGRecurrente);
            List<GastoComun> ListaLocal = new List<GastoComun>();
            
            Assert.IsTrue(adminReporteGastos.RetornarListaGastosDelMes().SequenceEqual(ListaLocal));

        }







    }
}
