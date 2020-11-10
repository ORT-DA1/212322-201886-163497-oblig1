using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Dominio;
using System.Collections.Generic;
using System.Linq;
using Excepciones;

namespace Test
{

    [TestClass]
    public class AdministradorCategoriasPrueba
    {

        private IRepositorio miRepositorio;
        private AdministradorCategorias adminCategorias;
        private Categoria unaCategoria;

        [TestInitialize]
        public void InitTests()
        {
            miRepositorio = new RepositorioMemoria();
            adminCategorias = new AdministradorCategorias(miRepositorio);
            unaCategoria = new Categoria();
        }


        [TestMethod]
        public void RetornarListaCategoriasPrueba()
        {
            List<Categoria> ListaLocal = new List<Categoria>();
            Assert.IsTrue(adminCategorias.RetornarListaCategorias().SequenceEqual(ListaLocal));

        }

        [TestMethod]
        public void RetornarCategoriaDePalabraClavePrueba()
        {

            Categoria c1 = new Categoria { Nombre = "Entretenimiento" };
            c1.AgregarPalabraClave("Cine");
            c1.AgregarPalabraClave("Serie");
            adminCategorias.AgregarCategoria(c1);

            Categoria c2 = new Categoria { Nombre = "Gastronimia" };
            c2.AgregarPalabraClave("Salir");
            c2.AgregarPalabraClave("Demorondanga");
            adminCategorias.AgregarCategoria(c2);


            unaCategoria = adminCategorias.CategoriaDePalabraClave("Cine");

            Assert.AreEqual(c1, unaCategoria);


        }

        [TestMethod]
        public void PalabraClaveYaIngresadaEnAlgunaListaPrueba()
        {
            Categoria cat = new Categoria { Nombre = "Auto" };
            cat.AgregarPalabraClave("Nafta");
            adminCategorias.AgregarCategoria(cat);
            Assert.IsTrue(adminCategorias.PalabraClaveYaIngresadaEnAlgunaLista("Nafta"));

        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoNoExistente))]
        public void BuscarPalabraQueNoEstaCateogiraPrueba()
        {
            adminCategorias.CategoriaDePalabraClave("Manzana");

        }

        [TestMethod]
        public void IgnorarMayusculasMinusulasCategoriaPrueba()
        {

            Categoria c1 = new Categoria { Nombre = "Auto" };
            c1.AgregarPalabraClave("Nafta");
            c1.AgregarPalabraClave("Patente");
            adminCategorias.AgregarCategoria(c1);

            unaCategoria = adminCategorias.CategoriaDePalabraClave("nAfta");
            Assert.AreEqual(c1, unaCategoria);

        }

        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoRepetido))]
        public void NoAgregarCategoriaRepetidaPrueba()
        {
            Categoria categoria = new Categoria { Nombre = "Hogar" };
            adminCategorias.AgregarCategoria(categoria);
            Categoria otraCategoria = new Categoria { Nombre = "Hogar" };
            adminCategorias.AgregarCategoria(otraCategoria);
        }


        [TestMethod]
        public void CantDeCategoriasDistintasDondeApareceLaDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            adminCategorias.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            adminCategorias.AgregarCategoria(otraCatrgoria);

            string descripcion = "Salida al Cine";

            Assert.AreEqual(2, adminCategorias.CantDeCategoriasDistintasDondeApareceLaDescripcion(descripcion));

        }

        [TestMethod]
        public void RetornarCategoriaDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            adminCategorias.AgregarCategoria(catrgoria);


            Assert.AreEqual(catrgoria, adminCategorias.RetornarCategoriaDeDescripcion("Voy al Cine"));

        }

        [TestMethod]
        public void CantDeCategoriasDistintasDeDescripcionPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            catrgoria.AgregarPalabraClave("Peli");
            adminCategorias.AgregarCategoria(catrgoria);


            string descripcion = "Peli al Cine";

            Assert.AreEqual(1, adminCategorias.CantDeCategoriasDistintasDondeApareceLaDescripcion(descripcion));

        }


        [TestMethod]
        [ExpectedException(typeof(ExcepcionElementoNoExistente))]
        public void RetornarCategoriaDeDescripcionQueNoEstaPrueba()
        {


            adminCategorias.RetornarCategoriaDeDescripcion("Manzana");

        }


        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void RetornarCategoriaDeDescripcionConVariasPalabrasClavesPrueba()
        {
            Categoria catrgoria = new Categoria { Nombre = "Entretenimiento" };
            catrgoria.AgregarPalabraClave("Cine");
            adminCategorias.AgregarCategoria(catrgoria);

            Categoria otraCatrgoria = new Categoria { Nombre = "GoingOut" };
            otraCatrgoria.AgregarPalabraClave("Salida");
            adminCategorias.AgregarCategoria(otraCatrgoria);

            adminCategorias.RetornarCategoriaDeDescripcion("Salida al Cine");


        }

        [TestMethod]
        public void AgregarCategoriaPrueba()
        {
            adminCategorias.AgregarCategoria(unaCategoria);
            Assert.IsFalse(adminCategorias.EsVaciaListaCategorias());
        }

        [TestMethod]
        public void EsVaciaListaCategoriasPrueba()
        {

            Assert.IsTrue(adminCategorias.EsVaciaListaCategorias());
        }

        [TestMethod]
        public void AgregarPalabraCalveCategoriaSeleccionadaPrueba()
        {

            adminCategorias.AgregarCategoria(unaCategoria);
            adminCategorias.AgregarPalabraClaveACategoria(unaCategoria, "Peaje");
            Assert.AreEqual(unaCategoria, adminCategorias.CategoriaDePalabraClave("Peaje"));
        }

        [TestMethod]
        public void EliminarPalabraClaveACategoriaPrueba()
        {

            adminCategorias.AgregarCategoria(unaCategoria);
            adminCategorias.AgregarPalabraClaveACategoria(unaCategoria, "PEAJE");
            adminCategorias.BorrarPalabraClaveACategoria(unaCategoria, "PEAJE");
            Assert.IsTrue(unaCategoria.EsVacia());
        }


        [TestMethod]
        public void RetornarPalabrasClaveCategoriaPrueba()
        {
            adminCategorias.AgregarCategoria(unaCategoria);
            adminCategorias.AgregarPalabraClaveACategoria(unaCategoria, "PEAJE");
            adminCategorias.RetornarPalabrasClaveDeCategoria(unaCategoria);
            Assert.IsFalse(unaCategoria.EsVacia());
        }

        [TestMethod]
        public void ConvertirStringACategoriaPrueba()
        {

            unaCategoria.Nombre = "Entretenimiento";
            adminCategorias.AgregarCategoria(unaCategoria);
            Assert.AreEqual(adminCategorias.RetornarCategoriaSegunString("Entretenimiento"), unaCategoria);

        }

        [TestMethod]
        public void EliminarCategoriaPrueba()
        {
            adminCategorias.AgregarCategoria(unaCategoria);
            adminCategorias.EliminarCategoria(unaCategoria);

            Assert.IsTrue(adminCategorias.EsVaciaListaCategorias());
          

        }
        

    }

}
