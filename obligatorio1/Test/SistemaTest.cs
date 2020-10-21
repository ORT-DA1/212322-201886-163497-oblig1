using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class SistemaTest
    {
        private Sistema sis;
        private Repositorio repo;
        private Gasto gasto;
        [TestInitialize]
        public void InitTest()
        {
            sis = new Sistema();
            repo = new Repositorio();
            gasto = new GastoComun();
        }
     /*  [TestMethod]
        public void crearRepositorioPrueba()
        {
            Repositorio repo2 = new Repositorio();
            Assert.AreEqual(repo2,repo);
        
        }
        [TestMethod]
        public void crearCategoriasPrueba()
        {
            Gasto gasto2 = new Gasto();
            Assert.AreEqual(gasto2,gasto);

        }*/

    }
}
