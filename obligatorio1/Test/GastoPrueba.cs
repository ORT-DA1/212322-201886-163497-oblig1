using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Security.Cryptography;
using Microsoft.Win32.SafeHandles;

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
        private Categoria cat;
      

        [TestInitialize]
        public void InitTests()
        {
            gasto = new Gasto();
            cat = new Categoria();
           
        }

        [TestMethod]
        public void PropertyMontoDecimalPrueba()
        {


            gasto.Monto = 0;
            Assert.AreEqual(0.00, gasto.Monto);

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void PropertyMontoPositivoPrueba()
        {
            gasto.Monto = -1;

        }

        [TestMethod]
        public void PropertyDescripcionPrueba()
        {


            gasto. Descripcion = "Una descripcion" ;
            string descrpcion = "Una descripcion";
            Assert.AreEqual(descrpcion, gasto.Descripcion);


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
        public void ConstructorPrueba()
        {
            Gasto gasto2 = new Gasto(1000, "Ir a comer", cat);
            Assert.AreEqual(gasto2.Monto,1000);

        }

       [TestMethod]
        public void ToStringGastoPrueba()
        {
            Assert.AreEqual(gasto.ToString(),"0,No hay descripcion,No hay nombre");

        }


    }

}

  

