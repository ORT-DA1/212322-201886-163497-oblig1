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

        

        [TestMethod]
        public void RetornarCategoriaDePalabraClavePrueba()
        {
           
            Categoria c1 = new Categoria { Nombre = "Entretenimiento" };
            c1.AgregarPalabraClave("Cine");
            c1.AgregarPalabraClave("Serie");
            listaCat.AgregarCategoria(c1);

            Categoria c2 = new Categoria { Nombre = "Gastronimia" };
            c2.AgregarPalabraClave("Salir");
            c2.AgregarPalabraClave("Demorondanga");
            listaCat.AgregarCategoria(c2);


            unaCategoria = listaCat.CategoriaDePalabraClave("Cine");
            
            Assert.AreEqual(c1, unaCategoria);


        }
        // esta prueba no andaba lo que me habilito a escribir el metodo de buscar
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuscarPalabraQueNoEstaPrueba()
        {


            listaCat.CategoriaDePalabraClave("Manzana");

        }

        [TestMethod]
        public void IgnorarMayusculasMinusulasPrueba()
        {

            Categoria c1 = new Categoria { Nombre = "Auto" };
            c1.AgregarPalabraClave("Nafta");
            c1.AgregarPalabraClave("Patente");
            listaCat.AgregarCategoria(c1);
            
            unaCategoria = listaCat.CategoriaDePalabraClave("nAfta");
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

        [TestMethod]
        public void PalabraClaveYaIngresadaEnAlgunaListaPrueba()
        {

            Categoria cat = new Categoria { Nombre = "Auto" };
            cat.AgregarPalabraClave("Nafta");
           
            listaCat.AgregarCategoria(cat);

            
            Assert.IsTrue(listaCat.PalabraClaveYaIngresadaEnAlgunaLista("Nafta"));

        }

        //NUEVO parecido a lo anteior pero retorna la categoria de la descripcion no solo de la palabra clave que nos es mas util
        [TestMethod]
        public void CantDeCategoriasDondeApareceLaDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            listaCat.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            listaCat.AgregarCategoria(otraCatrgoria);

            string descripcion = "Salida al Cine";
            Assert.AreEqual(2, listaCat.CantDeCategoriasDondeApareceLaDescripcion(descripcion));

        }

        [TestMethod]
        public void RetornarCategoriaDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            listaCat.AgregarCategoria(catrgoria);


            Assert.AreEqual(catrgoria, listaCat.RetornarCategoriaDeDescripcion("Voy al Cine"));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RetornarCategoriaDeDescripcionQueNoEstaPrueba()
        {

            
            listaCat.RetornarCategoriaDeDescripcion("Manzana");

        }

        // otra excepcion para cuando hay muchas palabras claves
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RetornarCategoriaDeDescripcionConVariasPalabrasClavesPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            listaCat.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            listaCat.AgregarCategoria(otraCatrgoria);

            listaCat.RetornarCategoriaDeDescripcion("Salida al Cine");
            

        }

    }


}
