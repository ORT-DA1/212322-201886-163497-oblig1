using Dominio;
using Excepciones;
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
        private IRepositorio miRepositorio;
        private AdministradorMonedas adminMonedas;
        private Moneda unaMoneda;
        private Moneda otraMoneda;

        [TestInitialize]
        public void InitTests()
        {
            miRepositorio = new RepositorioMemoria();
            adminMonedas = new AdministradorMonedas(miRepositorio);
            unaMoneda = new Moneda();
            otraMoneda = new Moneda();
        }

        [TestMethod]
        public void AgregarMonedaPrueba()
        {
            adminMonedas.AgregarMoneda(unaMoneda);
            List<Moneda> ListaLocal = new List<Moneda>();
            ListaLocal.Add(unaMoneda);
            Assert.IsTrue(adminMonedas.RetornarListaMonedas().SequenceEqual(ListaLocal));
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoRepetido))]
        public void NoAgregarMonedaRepetidaPrueba()
        {
            adminMonedas.AgregarMoneda(unaMoneda);
            adminMonedas.AgregarMoneda(unaMoneda);
        }
    }


}
