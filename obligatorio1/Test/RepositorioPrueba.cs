using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;

namespace Test
{

    [TestClass]
    public class RepositorioPrueba
    {


        private Repositorio repositorio;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            repositorio = new Repositorio();
            unaCategoria = new Categoria();
        }



        [TestMethod]
        public void CrearListaCategoriasVaciaPrueba()
        {
             Assert.IsTrue(repositorio.EsVaciaListaCategorias());

        }


      [TestMethod]
        public void AlAgregarCateogoriaNoEsVacioPrueba()
        {
            
           
            repositorio.AgregarCategoria(unaCategoria);
           
            Assert.IsFalse(repositorio.EsVaciaListaCategorias());

        }

        
       
        [TestMethod]
        public void EliminarCategoriaPrueba()
        {
            
            repositorio.AgregarCategoria(unaCategoria);
            repositorio.EliminarCategoria(unaCategoria);

            Assert.IsTrue(repositorio.EsVaciaListaCategorias());

        }

        

        [TestMethod]
        public void RetornarCategoriaDePalabraClavePrueba()
        {
           
            Categoria c1 = new Categoria { Nombre = "Entretenimiento" };
            c1.AgregarPalabraClave("Cine");
            c1.AgregarPalabraClave("Serie");
            repositorio.AgregarCategoria(c1);

            Categoria c2 = new Categoria { Nombre = "Gastronimia" };
            c2.AgregarPalabraClave("Salir");
            c2.AgregarPalabraClave("Demorondanga");
            repositorio.AgregarCategoria(c2);


            unaCategoria = repositorio.CategoriaDePalabraClave("Cine");
            
            Assert.AreEqual(c1, unaCategoria);


        }
        
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuscarPalabraQueNoEstaCateogiraPrueba()
        {

            repositorio.CategoriaDePalabraClave("Manzana");

        }

        [TestMethod]
        public void IgnorarMayusculasMinusulasCategoriaPrueba()
        {

            Categoria c1 = new Categoria { Nombre = "Auto" };
            c1.AgregarPalabraClave("Nafta");
            c1.AgregarPalabraClave("Patente");
            repositorio.AgregarCategoria(c1);
            
            unaCategoria = repositorio.CategoriaDePalabraClave("nAfta");
            Assert.AreEqual(c1, unaCategoria);

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void NoAgregarCategoriaRepetidaPrueba()
        {
            Categoria c1 = new Categoria { Nombre = "Hogar" };
            repositorio.AgregarCategoria(c1);
            Categoria c2 = new Categoria { Nombre = "Hogar" };
            repositorio.AgregarCategoria(c2);
        }

        [TestMethod]
        public void PalabraClaveYaIngresadaEnAlgunaListaPrueba()
        {

            Categoria cat = new Categoria { Nombre = "Auto" };
            cat.AgregarPalabraClave("Nafta");
           
            repositorio.AgregarCategoria(cat);

            
            Assert.IsTrue(repositorio.PalabraClaveYaIngresadaEnAlgunaLista("Nafta"));

        }

       // PRUEBAS PARA IDENTIFICAR LA CATEGORIA DE LA DESCRIPCION 

        [TestMethod]
        public void CantDeCategoriasDistintasDondeApareceLaDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            repositorio.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            repositorio.AgregarCategoria(otraCatrgoria);

            string descripcion = "Salida al Cine";
            
            Assert.AreEqual(2, repositorio.CantDeCategoriasDondeApareceLaDescripcion(descripcion));

        }

        [TestMethod]
        public void CantDeCategoriasDistintasDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            catrgoria.AgregarPalabraClave("Peli");
            repositorio.AgregarCategoria(catrgoria);

            
            string descripcion = "Peli al Cine";
            
            Assert.AreEqual(1, repositorio.CantDeCategoriasDondeApareceLaDescripcion(descripcion));

        }
      

        [TestMethod]
        public void RetornarCategoriaDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            repositorio.AgregarCategoria(catrgoria);


            Assert.AreEqual(catrgoria, repositorio.RetornarCategoriaDeDescripcion("Voy al Cine"));

        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RetornarCategoriaDeDescripcionQueNoEstaPrueba()
        {

            
            repositorio.RetornarCategoriaDeDescripcion("Manzana");

        }

        // otra excepcion para cuando hay muchas palabras claves
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RetornarCategoriaDeDescripcionConVariasPalabrasClavesPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            repositorio.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            repositorio.AgregarCategoria(otraCatrgoria);

            repositorio.RetornarCategoriaDeDescripcion("Salida al Cine");
            

        }

        [TestMethod]
        public void CrearYAgregarCategoriaPrueba()
        {
            repositorio.CrearYAgregarCategoria("Viajes");
            Assert.IsFalse(repositorio.EsVaciaListaCategorias());
        }


 

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void CrearYAgregarCategoriaYaExistentePrueba()
        {
            repositorio.CrearYAgregarCategoria("Viajes");
            repositorio.CrearYAgregarCategoria("Viajes");
        }

        [TestMethod]
        public void AgregarPalabraCalveCategoriaSeleccionadaPrueba()
        {

            repositorio.AgregarCategoria(unaCategoria);
            repositorio.AgregarPalabraClaveACategoria(unaCategoria, "Peaje");
            Assert.AreEqual(unaCategoria, repositorio.CategoriaDePalabraClave("Peaje"));
        }

        [TestMethod]
        public void EliminarPalabraClaveACategoriaPrueba()
        {

            repositorio.AgregarCategoria(unaCategoria);
            repositorio.AgregarPalabraClaveACategoria(unaCategoria, "PEAJE");
            repositorio.BorrarPalabraClaveACategoria(unaCategoria, "PEAJE");
            Assert.IsTrue(unaCategoria.EsVacia());
        }












        /*        [TestMethod]
                public void AlAgregarPalabraClaveGeneralNoEsVacioPrueba()
                {
                   repositorio.AgregarAListaTodasPalabrasClave(unaCategoria,"Cine");

                    Assert.IsFalse(repositorio.EsVaciaListaTodasPalabrasClave());

                }


                [TestMethod]
                public void ExistePalabraEnListaTodasPalabrasClavePrueba()
                {
                    repositorio.AgregarAListaTodasPalabrasClave(unaCategoria,"Cine");

                    Assert.IsTrue(repositorio.ExistePalabraEnListaTodasPalabrasClave("Cine"));
                }


                [TestMethod]
                [ExpectedException(typeof(InvalidOperationException))]
                public void NoRepetirPalabraEnListaTodasPalabrasClavePrueba()
                {
                    repositorio.AgregarAListaTodasPalabrasClave(unaCategoria,"Cine");
                    repositorio.AgregarAListaTodasPalabrasClave(unaCategoria,"cine");

                }

                [TestMethod]
                public void PalabraAgregadaACategoriaSeleccionada()
                {
                    repositorio.AgregarAListaTodasPalabrasClave(unaCategoria, "Cine");
                    Assert.IsTrue(unaCategoria.PalabrasClave.SequenceEqual(repositorio.ListaDeTodasPalabrasClave));
                }
        */


    }


}
