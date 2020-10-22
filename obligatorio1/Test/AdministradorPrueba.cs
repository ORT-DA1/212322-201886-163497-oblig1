using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using Excepciones;
//using Dominio;

namespace Test
{
    [TestClass]
    class AdministradorPrueba
    {
        private Administrador unAdministrador;

        [TestInitialize]
        public void InitTests()
        {
            unAdministrador = new Administrador();
           
        }

        [TestMethod]
        public void CrearListaCategoriasVaciaPrueba()
        {
            Assert.IsTrue(unAdministrador.EsVaciaListaCategorias());

        }

        /*
         [TestMethod]
        public void AlAgregarCateogoriaNoEsVacioPrueba()
        {


            repositorio.AgregarCategoria(unaCategoria);

            Assert.IsFalse(repositorio.EsVaciaListaCategorias());

        }
         */




    }
}
