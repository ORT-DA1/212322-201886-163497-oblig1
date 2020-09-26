using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using obligatorio1;

namespace Test
{
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
        public void ListaVaciaPrueba()
        {
            List<String> palabrasClave = new List< String > ();
            Categoria categoria = new Categoria();
            string palabra = "Cine";
            categoria.AgregarPalabraClave(palabra,palabrasClave);
            Assert.IsFalse(categoria.esVacia());
        }
    }
}
