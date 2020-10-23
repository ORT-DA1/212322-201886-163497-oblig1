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
    public class AdministradorPresupuestoPrueba
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        private GastoComun unGastoComun;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            adminPresupuesto = new AdministradorPresupuesto();
            adminCategorias = new AdministradorCategorias();
            unGastoComun = new GastoComun();
            unaCategoria = new Categoria();

        }

        [TestMethod]
        public void RetornarListaPresupuestoPrueba()
        {

            List<Presupuesto> ListaLocal = new List<Presupuesto>();
            Assert.IsTrue(adminGastosComunes.RetornarListaGastosComunes().SequenceEqual(ListaLocal));

        }

    }
}
