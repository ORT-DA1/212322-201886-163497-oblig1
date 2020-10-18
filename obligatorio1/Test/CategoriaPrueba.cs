using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones;

namespace Test
{

    /*
     * 
     * 
     * Nombre de la categoria entre 3-15 caracteres.
     * Seleccionar una palabra clave de la lista y la retorne.
     */

    [TestClass]
    public class CategoriaPrueba
    {
        private Categoria categoria;
        Administrador listaCategorias;

        [TestInitialize]
        public void InitTests()
        {
            categoria = new Categoria();
            listaCategorias = new Administrador();
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
        public void ValidarNombrePrueba()
        {
            Categoria categoria1 = new Categoria() { Nombre = "B" };
            Categoria categoria2 = new Categoria() { Nombre = "PalabraMuyMuyLarga" };
        }



        //NUEVO DEFINIR EL EQUALS EN CATGORIA 

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
    
    }
}
