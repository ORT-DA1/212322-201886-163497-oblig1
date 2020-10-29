using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using Excepciones;

namespace Test
{

    [TestClass]
    public class CategoriaPrueba
    {
        private Categoria categoria;

        [TestInitialize]
        public void InitTests()
        {
            categoria = new Categoria();
        }

        [TestMethod]
        public void PropertyNombrePrueba()
        {
            categoria.Nombre = "Entretenimiento";
            string nombre = "Entretenimiento";
            Assert.AreEqual(nombre, categoria.Nombre);
        }

        [TestMethod]
        public void CrearCatListaVaciaPrueba()
        {
            Assert.IsTrue(categoria.EsVacia());
        }

        [TestMethod]
        public void AgregarPalabraClavePrueba()
        {
            categoria.AgregarPalabraClave("Cine");
            Assert.IsFalse(categoria.EsVacia());
        }

        [TestMethod]
        public void EliminarPalabraClavePrueba()
        {
            categoria.AgregarPalabraClave("Cine");
            categoria.BorrarPalabraClave("Cine");
            Assert.IsTrue(categoria.EsVacia());
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void ListaMax10PalabrasPrueba()
        {
            for (int i = 0; i < 11; i++)
            {
                categoria.AgregarPalabraClave("Manzana");
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionPalabraLarga))]
        public void ValidarNombreCortoPrueba()
        {
            Categoria categoria1 = new Categoria() { Nombre = "B" };
        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionPalabraLarga))]
        public void ValidarNombreLargoPrueba()
        {
            Categoria categoria2 = new Categoria() { Nombre = "PalabraMuyMuyLarga" };
        }

        [TestMethod]
        public void EqualsPrueba()
        {
            Categoria categoria1 = new Categoria { Nombre = "Entretenimiento" };
            Categoria categoria2 = new Categoria { Nombre = "Entretenimiento" };
            Assert.AreEqual(categoria1, categoria2);
        }

        [TestMethod]
        public void ExistePalabraClavePrueba()
        {
            categoria.AgregarPalabraClave("Cine");
            Assert.IsTrue(categoria.ExistePalabraClave("cine"));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoRepetirPalabraClavePrueba()
        {
            categoria.AgregarPalabraClave("Cine");
            categoria.AgregarPalabraClave("Cine");
        }

        [TestMethod]
        public void toStringCategoriaPrueba()
        {
            Assert.AreEqual(categoria.ToString(), "No hay nombre");
        }

    }
}
