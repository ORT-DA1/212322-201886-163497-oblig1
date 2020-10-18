using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Linq;
using Excepciones;

namespace Test
{

    [TestClass]
    public class AdministradorPrueba
    {


        private Administrador Administrador;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            Administrador = new Administrador();
            unaCategoria = new Categoria();
        }



        [TestMethod]
        public void CrearListaCategoriasVaciaPrueba()
        {
             Assert.IsTrue(Administrador.EsVaciaListaCategorias());

        }


      [TestMethod]
        public void AlAgregarCateogoriaNoEsVacioPrueba()
        {
            
           
            Administrador.AgregarCategoria(unaCategoria);
           
            Assert.IsFalse(Administrador.EsVaciaListaCategorias());

        }

        
       
        [TestMethod]
        public void EliminarCategoriaPrueba()
        {
            
            Administrador.AgregarCategoria(unaCategoria);
            Administrador.EliminarCategoria(unaCategoria);

            Assert.IsTrue(Administrador.EsVaciaListaCategorias());

        }

        

        [TestMethod]
        public void RetornarCategoriaDePalabraClavePrueba()
        {
           
            Categoria c1 = new Categoria { Nombre = "Entretenimiento" };
            c1.AgregarPalabraClave("Cine");
            c1.AgregarPalabraClave("Serie");
            Administrador.AgregarCategoria(c1);

            Categoria c2 = new Categoria { Nombre = "Gastronimia" };
            c2.AgregarPalabraClave("Salir");
            c2.AgregarPalabraClave("Demorondanga");
            Administrador.AgregarCategoria(c2);


            unaCategoria = Administrador.CategoriaDePalabraClave("Cine");
            
            Assert.AreEqual(c1, unaCategoria);


        }
        
        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoNoExistente))]
        public void BuscarPalabraQueNoEstaCateogiraPrueba()
        {

            Administrador.CategoriaDePalabraClave("Manzana");

        }

        [TestMethod]
        public void IgnorarMayusculasMinusulasCategoriaPrueba()
        {

            Categoria c1 = new Categoria { Nombre = "Auto" };
            c1.AgregarPalabraClave("Nafta");
            c1.AgregarPalabraClave("Patente");
            Administrador.AgregarCategoria(c1);
            
            unaCategoria = Administrador.CategoriaDePalabraClave("nAfta");
            Assert.AreEqual(c1, unaCategoria);

        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoRepetido))]
        public void NoAgregarCategoriaRepetidaPrueba()
        {
            Categoria c1 = new Categoria { Nombre = "Hogar" };
            Administrador.AgregarCategoria(c1);
            Categoria c2 = new Categoria { Nombre = "Hogar" };
            Administrador.AgregarCategoria(c2);
        }

        [TestMethod]
        public void PalabraClaveYaIngresadaEnAlgunaListaPrueba()
        {

            Categoria cat = new Categoria { Nombre = "Auto" };
            cat.AgregarPalabraClave("Nafta");
           
            Administrador.AgregarCategoria(cat);

            
            Assert.IsTrue(Administrador.PalabraClaveYaIngresadaEnAlgunaLista("Nafta"));

        }

       // PRUEBAS PARA IDENTIFICAR LA CATEGORIA DE LA DESCRIPCION 

        [TestMethod]
        public void CantDeCategoriasDistintasDondeApareceLaDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            Administrador.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            Administrador.AgregarCategoria(otraCatrgoria);

            string descripcion = "Salida al Cine";
            
            Assert.AreEqual(2, Administrador.CantDeCategoriasDistintasDondeApareceLaDescripcion(descripcion));

        }

        [TestMethod]
        public void CantDeCategoriasDistintasDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            catrgoria.AgregarPalabraClave("Peli");
            Administrador.AgregarCategoria(catrgoria);

            
            string descripcion = "Peli al Cine";
            
            Assert.AreEqual(1, Administrador.CantDeCategoriasDistintasDondeApareceLaDescripcion(descripcion));

        }
      

        [TestMethod]
        public void RetornarCategoriaDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            Administrador.AgregarCategoria(catrgoria);


            Assert.AreEqual(catrgoria, Administrador.RetornarCategoriaDeDescripcion("Voy al Cine"));

        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoNoExistente))]
        public void RetornarCategoriaDeDescripcionQueNoEstaPrueba()
        {

            
            Administrador.RetornarCategoriaDeDescripcion("Manzana");

        }

        // otra excepcion para cuando hay muchas palabras claves
        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RetornarCategoriaDeDescripcionConVariasPalabrasClavesPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            Administrador.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            Administrador.AgregarCategoria(otraCatrgoria);

            Administrador.RetornarCategoriaDeDescripcion("Salida al Cine");
            

        }

        [TestMethod]
        public void CrearYAgregarCategoriaPrueba()
        {
            Administrador.CrearYAgregarCategoria("Viajes");
            Assert.IsFalse(Administrador.EsVaciaListaCategorias());
        }


 

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoRepetido))]
        public void CrearYAgregarCategoriaYaExistentePrueba()
        {
            Administrador.CrearYAgregarCategoria("Viajes");
            Administrador.CrearYAgregarCategoria("Viajes");
        }

        [TestMethod]
        public void AgregarPalabraCalveCategoriaSeleccionadaPrueba()
        {

            Administrador.AgregarCategoria(unaCategoria);
            Administrador.AgregarPalabraClaveACategoria(unaCategoria, "Peaje");
            Assert.AreEqual(unaCategoria, Administrador.CategoriaDePalabraClave("Peaje"));
        }

        [TestMethod]
        public void EliminarPalabraClaveACategoriaPrueba()
        {

            Administrador.AgregarCategoria(unaCategoria);
            Administrador.AgregarPalabraClaveACategoria(unaCategoria, "PEAJE");
            Administrador.BorrarPalabraClaveACategoria(unaCategoria, "PEAJE");
            Assert.IsTrue(unaCategoria.EsVacia());
        }




    }


}
