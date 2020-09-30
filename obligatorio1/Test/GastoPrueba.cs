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

        /*   [TestMethod]
           [ExpectedException(typeof(IndexOutOfRangeException))]
           public void RangoFechaPrueba()
           {

               gasto.Fecha = new DateTime(2017, 31, 12, 0, 0, 0);


           }*/

        
        //TRATANDO DE PROBAR QUE SE ASIGNE UNA CATEGORIA AL GASTO
       [TestMethod]
        public void AsignarCategoriaPrueba()
        {
            gasto.Descripcion = "cine";

           List <Categoria> listaCategorias = new List <Categoria>();

            Categoria c1 = new Categoria { Nombre = "Entretenimeinto" };
            c1.AgregarPalabraClave("Cine");
            c1.AgregarPalabraClave("Serie");

            listaCategorias.Add(c1);

            Categoria c2 = new Categoria { Nombre = "Gastronimia" };
            c2.AgregarPalabraClave("Salir a comer");
            c2.AgregarPalabraClave("Demorondanga");
            listaCategorias.Add(c2);




        }




    }

}

  

