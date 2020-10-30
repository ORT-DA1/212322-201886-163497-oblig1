using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Dominio;

namespace Test
{
    [TestClass]
    public class GastoRecurrentePrueba
    {
        private GastoRecuerrente gastoRec;
        private Categoria cat;

        [TestInitialize]
        public void InitTests()
        {
            gastoRec = new GastoRecuerrente();
            cat = new Categoria();

        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoInferiorFechaPrueba()
        {
            gastoRec.Fecha = 0;
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void RangoSuperiorFechaGastoRecurrentePrueba()
        {
            gastoRec.Fecha = 29;
        }

        [TestMethod]
        public void ConstructorGastoRecurrentePrueba()
        {
           GastoRecuerrente gastoRec2 = new GastoRecuerrente(1000 , "Ir a comer", cat ,10);
           Assert.AreEqual(gastoRec2.Fecha, 10);
        }

        [TestMethod]
        public void ToStringGastoRecurrentePrueba()
        {

            Assert.AreEqual(gastoRec.ToString(),"Monto: 0, Descripcion: No hay descripcion, Categoria: No hay nombre,Dia: 1");
       }

    }
}
