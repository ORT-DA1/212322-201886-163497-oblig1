using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorio1;


namespace Test
{

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
            Gasto gasto = new Gasto() { Descripcion = "a"};

        }





    }
       
}

  

