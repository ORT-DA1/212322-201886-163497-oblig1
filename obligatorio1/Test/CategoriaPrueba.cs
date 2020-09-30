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
        public void DevolverListaPCPrueba()
        {
            
            categoria.AgregarPalabraClave("Cine");
            categoria.AgregarPalabraClave("Teatro");

            var unaLista = new List<string>() { "Cine", "Teatro" };

            Assert.IsTrue(categoria.GetListaPC().SequenceEqual(unaLista));
         
        }
        
        [TestMethod]
        public void EliminarPalabraClavePrueba()
        {
            
            categoria.AgregarPalabraClave("Cine");
            categoria.BorrarPalabraClave("Cine");
            Assert.IsTrue(categoria.EsVacia());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ListaMax10PalabrasPrueba()
        {
            
            
            for(int i=0; i<11; i++)
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




        
        [TestMethod]
        public void BuscarPalabraPrueba()
        {
           
            categoria.AgregarPalabraClave("Palabra");
            String pEncontrada = categoria.BuscarPClave("Palabra");
            Assert.AreEqual(pEncontrada, "Palabra");
        }

        

         
          [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuscarPalabraQueNoEstaPrueba()
        {
           
            String palabraNoEsta = "Manzana";
           
            categoria.BuscarPClave(palabraNoEsta);
            
        }

        

    }
}
