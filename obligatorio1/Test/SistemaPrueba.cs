using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;



namespace Test
{
    [TestClass]
    public class SistemaPrueba
    {
        private Sistema sistema;
        private Repositorio repositorio;
        private Gasto gasto;

        [TestInitialize]
        public void InitTest()
        {
            sistema = new Sistema();
            repositorio = new Repositorio();
            gasto = new GastoComun();
        }

       public void CrearYAgregarCategoriaPrueba()
        {
            
            sistema.CrearYAgregarCategoria("Viajes");
            Assert.IsFalse(sistema.Repositorio.EsVaciaListaCategorias());
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
