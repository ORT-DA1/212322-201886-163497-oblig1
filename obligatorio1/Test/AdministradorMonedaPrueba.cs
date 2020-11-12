using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorio1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    [TestClass]
    public class AdministradorMonedaPrueba
    {
        private Repositorio miRepositorio;
        private AdministradorMonedas adminMonedas;
        private Moneda unaMoneda;
        private Moneda otraMoneda;

        [TestInitialize]
        public void InitTests()
        {
            miRepositorio = new Repositorio();
            adminMonedas = new AdministradorMonedas(miRepositorio);
            unaMoneda = new Moneda();
            otraMoneda = new Moneda();
        }

        [TestMethod]
        public void AgregarMonedaPrueba()
        {
            AdministradorMonedas.AgregarMoneda(unaMoneda);
            List<Moneda> ListaLocal = new List<Moneda>();
            ListaLocal.Add(unaMoneda);
            Assert.AreEqual(ListaLocal, AdministradorMonedas.RetornarListaMonedas());
        }

        [TestMethod]
        public void NoAgregarMonedaRepetidaPrueba()
        {
            AdministradorMonedas.AgregarMoneda(unaMoneda);

        }
    }


}
