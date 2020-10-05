using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Security.Cryptography;


namespace Test
{

    [TestClass]
    public class ListaCategoriasPrueba
    {


        private ListaCategorias listaCat;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            listaCat = new ListaCategorias();
            unaCategoria = new Categoria();
        }



        [TestMethod]
        public void CrearListaVaciaPrueba()
        {
             Assert.IsTrue(listaCat.EsVacia());

        }


      [TestMethod]
        public void AlAgregarNoEsVacioPrueba()
        {
            
           
            listaCat.AgregarCategoria(unaCategoria);
           
            Assert.IsFalse(listaCat.EsVacia());

        }

        [TestMethod]
        public void EliminarCategoriaPrueba()
        {
            
            listaCat.AgregarCategoria(unaCategoria);
            listaCat.EliminarCategoria(unaCategoria);

            Assert.IsTrue(listaCat.EsVacia());

        }

        //NUEVO

        [TestMethod]
        public void BuscarPalabraClavePrueba()
        {
           
            Categoria c1 = new Categoria { Nombre = "Entretenimiento" };
            c1.AgregarPalabraClave("Cine");
            c1.AgregarPalabraClave("Serie");
            listaCat.AgregarCategoria(c1);

            Categoria c2 = new Categoria { Nombre = "Gastronimia" };
            c2.AgregarPalabraClave("Salir a comer");
            c2.AgregarPalabraClave("Demorondanga");
            listaCat.AgregarCategoria(c2);


            unaCategoria = listaCat.BuscarPalabraClave("Cine");
            // la categoria c1 deberia ser igual a lo que devuelve el metodo BuscarPalabraClave de cine 
            Assert.AreEqual(c1, unaCategoria);


        }
        // esta prueba no andaba lo que me habilito a escribir el metodo de buscar
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuscarPalabraQueNoEstaPrueba()
        {


            listaCat.BuscarPalabraClave("Manzana");

        }

        [TestMethod]
        public void IgnorarMayusculasMinusulasPrueba()
        {

            Categoria c1 = new Categoria { Nombre = "Auto" };
            c1.AgregarPalabraClave("Nafta");
            c1.AgregarPalabraClave("Patente");
            listaCat.AgregarCategoria(c1);
            
            unaCategoria = listaCat.BuscarPalabraClave("nAfta");
            Assert.AreEqual(c1, unaCategoria);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoAgregarCategoriaRepetidaPrueba()
        {
            Categoria c1 = new Categoria { Nombre = "Hogar" };
            listaCat.AgregarCategoria(c1);
            Categoria c2 = new Categoria { Nombre = "Hogar" };
            listaCat.AgregarCategoria(c2);
        }


    }


}
