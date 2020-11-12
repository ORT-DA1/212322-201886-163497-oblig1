using Dominio;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Test
{
    [TestClass]
    public class PalabraClavePrueba
    {

        private PalabraClave palabraClaveUno;
        
        [TestInitialize]
        public void InitTests()
        {
            palabraClaveUno = new PalabraClave();
        }

        [TestMethod]
        public void PropertyNombrePalabraPrueba()
        {
            palabraClaveUno.Palabra = "Nafta";
            string palabra = "NAFTA";
            Assert.AreEqual(palabraClaveUno.Palabra, palabra);
        }

        [TestMethod]
        public void EqualsPrueba()
        {
            palabraClaveUno.Palabra = "Nafta";
            PalabraClave palabraClaveDos = new PalabraClave { Palabra = "Nafta" };
            Assert.AreEqual(palabraClaveUno, palabraClaveDos);
        }

    }
}
