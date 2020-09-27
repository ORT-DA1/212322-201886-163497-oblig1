using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorio1;


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

        [TestMethod]
        public void PropertyMontoPrueba()
        {


            Gasto gasto = new Gasto() { Monto = 0 };
            int monto = 0;
            Assert.AreEqual(monto, gasto.Monto);


        }

        [TestMethod]
        public void PropertyDescripcionPrueba()
        {


            Gasto gasto = new Gasto() { Descripcion = "Una descripcion" };
            string descrpcion = "Una descripcion";
            Assert.AreEqual(descrpcion, gasto.Descripcion);


        }

        [TestMethod]
        public void PropertyFechaPrueba()
        {
            Gasto gasto = new Gasto() { Fecha = "03/03/1999" };
            string fecha = "03/03/1999";
            Assert.AreEqual(fecha, gasto.Fecha);

        }

        [TestMethod]
        public void PropertyCategoriaPrueba()
        {
            Categoria cat = new Categoria();
 
            Gasto gasto = new Gasto() { Categoria = cat };
            Assert.AreEqual(cat , gasto.Categoria);


        }


        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoDescripcionPrueba()
        {
            Gasto gasto1 = new Gasto() { Descripcion = "a"};
            Gasto gasto2 = new Gasto() { Descripcion = "abcdefghijklmnopqrsuvwxyz" };


        }





    }
       
}

  

