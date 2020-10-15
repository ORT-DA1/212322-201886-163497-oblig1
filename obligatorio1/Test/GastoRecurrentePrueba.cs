using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Test
{
    [TestClass]
    class GastoRecurrentePrueba
    {
        private GastoRecuerrente gastoRec;

        [TestInitialize]
        public void InitTests()
        {
            gastoRec = new GastoRecuerrente();
        }


          [TestMethod]
          [ExpectedException(typeof(IndexOutOfRangeException))]
          public void RangoInferiorFechaPrueba()
          {

            gastoRec.Fecha = 1;

          }
    }
}
