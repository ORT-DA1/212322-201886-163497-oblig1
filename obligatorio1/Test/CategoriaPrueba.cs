using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;

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
        Repositorio listaCategorias;

        [TestInitialize]
        public void InitTests()
        {
            categoria = new Categoria();
            listaCategorias = new Repositorio();
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
        public void DevolverListaPClavePrueba()
        {

            categoria.AgregarPalabraClave("Cine");
            categoria.AgregarPalabraClave("Teatro");

            var unaLista = new List<string>() { "CINE", "TEATRO" };

            Assert.IsTrue(categoria.GetListaPClave().SequenceEqual(unaLista));

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
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ValidarNombrePrueba()
        {
            Categoria categoria1 = new Categoria() { Nombre = "B" };
            Categoria categoria2 = new Categoria() { Nombre = "PaulaSaraMicaela" };
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
      /*  [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoRepetirPalabraClaveEnOtraCategoriaPrueba()
        {
            categoria.AgregarPalabraClave("Cine");
            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Cine");

        }*/

/*          [TestMethod]
            [ExpectedException(typeof(InvalidOperationException))]
            public void NoRepetirPalabraClaveEnOtraCategoriaPrueba()
            {
                Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
                catrgoria.AgregarPalabraClave("Cine",ListaCategorias);
                listaCategorias.NoAgregarCategoria(catrgoria);

                Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
                otraCatrgoria.NoAgregarPalabraClave("Cine",ListaCategorias);

            }*/
    }
}
