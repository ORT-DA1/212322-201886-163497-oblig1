using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Security.Cryptography;

namespace Test
{
    /*
     * monto > 0
     * Si no encuentra una categoria la seleccion queda vacia asi el usuario elija manualmente.
     * La fecha comprendida entre el 01/01/2018 y el 31/12/2030
     * categoria no puede quedarr vacia.
     */

    [TestClass]
    public class GastoPrueba
    {
        private Gasto gasto;
        ListaCategorias listaCategorias;

        [TestInitialize]
        public void InitTests()
        {
            gasto = new Gasto();
            listaCategorias = new ListaCategorias();
        }

        [TestMethod]
        public void PropertyMontoPrueba()
        {


            gasto.Monto = 0 ;
            int monto = 0;
            Assert.AreEqual(monto, gasto.Monto);


        }

        [TestMethod]
        public void PropertyDescripcionPrueba()
        {


            gasto. Descripcion = "Una descripcion" ;
            string descrpcion = "Una descripcion";
            Assert.AreEqual(descrpcion, gasto.Descripcion);


        }

        [TestMethod]
        public void PropertyFechaPrueba()
        {
           

            gasto.Fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            DateTime fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            Assert.AreEqual(fecha, gasto.Fecha);

        }

        [TestMethod]
        public void PropertyCategoriaPrueba()
        {
            Categoria cat = new Categoria();
 
            gasto.Categoria = cat ;
            Assert.AreEqual(cat , gasto.Categoria);


        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoDescripcionPrueba()
        {
            gasto.Descripcion = "a";
            Gasto gasto2 = new Gasto() { Descripcion = "abcdefghijklmnopqrsuvwxyz" };


        }

        [TestMethod]
           [ExpectedException(typeof(IndexOutOfRangeException))]
           public void RangoInferiorFechaPrueba()
           {

               gasto.Fecha = new DateTime(2017, 12, 31, 0, 0, 0);


           }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoSuperiorFechaPrueba()
        {

            gasto.Fecha = new DateTime(2031, 1, 1, 0, 0, 0);


        }

        /*
         [TestMethod]
        public void SepararDescripcionEnPalabras()
        {
            String descripcion = "Salida al cine";
            gasto.SepararPalabras(descripcion);

        }
         */

 

        //TRATANDO DE PROBAR QUE SE ASIGNE UNA CATEGORIA AL GASTO sin terminar
        [TestMethod]
        public void AsignarCategoriaAGastoPrueba()
        {
               
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            catrgoria.AgregarPalabraClave("Serie");

            listaCategorias.AgregarCategoria(catrgoria);

            gasto.AsignarCategoriaSegunDescripcion(listaCategorias, "Cine");


            Assert.AreEqual(gasto.Categoria, catrgoria);
        }




    }

}

  

