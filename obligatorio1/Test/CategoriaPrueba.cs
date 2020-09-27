using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorio1;
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
        [TestMethod]
        public void PropertyNombrePrueba()
        {
            Categoria categoria = new Categoria() { Nombre = "Entretenimiento" } ;
            string nombre = "Entretenimiento";
            Assert.AreEqual(nombre, categoria.Nombre);
        }



        [TestMethod]
        public void CrearCatListaVaciaPrueba()
        {
            Categoria categoria = new Categoria();
            Assert.IsTrue(categoria.EsVacia());
        
        }

        [TestMethod]
        public void AgregarPalabraClavePrueba()
        {
            Categoria categoria = new Categoria();
            categoria.AgregarPalabraClave("Cine");
            Assert.IsFalse(categoria.EsVacia());

        }


        [TestMethod]
        public void DevolverListaPCPrueba()
        {
            Categoria categoria = new Categoria();
            categoria.AgregarPalabraClave("Cine");
            categoria.AgregarPalabraClave("Teatro");

            var unaLista = new List<string>() { "Cine", "Teatro" };

            Assert.IsTrue(categoria.GetListaPC().SequenceEqual(unaLista));
         
        }
        
        [TestMethod]
        public void EliminarPalabraClavePrueba()
        {
            Categoria categoria = new Categoria();
            categoria.AgregarPalabraClave("Cine");
            categoria.BorrarPalabraClave("Cine");
            Assert.IsTrue(categoria.EsVacia());
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void ListaMax10PalabrasPrueba()
        {
            Categoria categoria = new Categoria();
            
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
            Categoria categoria = new Categoria();
            categoria.AgregarPalabraClave("Palabra");
            String pEncontrada = categoria.BuscarPClave("Palabra");
            Assert.AreEqual(pEncontrada, "Palabra");
        }

        

         
          [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void BuscarPalabraQueNoEstaPrueba()
        {
            Categoria categoria = new Categoria();
            String palabraNoEsta = "Manzana";
           
            categoria.BuscarPClave(palabraNoEsta);
            
        }
         
         



    }
}
