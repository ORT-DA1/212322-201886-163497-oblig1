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
     * categoria queda vacia si: 
     * -Una palabra clave esta en dos categorias. 
     * -En la descripcion hay dos palabras claves de distintas categorias. 
     * 
     */

    [TestClass]
    public class GastoPrueba
    {
        private Gasto gasto;
       

        [TestInitialize]
        public void InitTests()
        {
            gasto = new Gasto();
           
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
/*
        [TestMethod]
        public void PropertyFechaPrueba()
        {
           

            gasto.Fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            DateTime fecha = new DateTime(2020, 5, 1, 8, 30, 52);
            Assert.AreEqual(fecha, gasto.Fecha);

        }*/

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

   /*     [TestMethod]
           [ExpectedException(typeof(IndexOutOfRangeException))]
           public void RangoInferiorFechaPrueba()
           {

               gasto.Fecha = new DateTime(2017, 12, 31, 0, 0, 0);


           }*/
/*
        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoSuperiorFechaPrueba()
        {

            gasto.Fecha = new DateTime(2031, 1, 1, 0, 0, 0);


        }
*/
       


    }

}

  

