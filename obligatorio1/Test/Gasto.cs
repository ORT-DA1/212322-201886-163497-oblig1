using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using obligatorio1;


namespace Test
{
    /*
            Se pide una descripción, un monto y una fecha. A partir de la descripción,
            el sistema intenta encontrar la
            categoría, buscando las palabras claves de cada categoría en el texto de la
            descripción. Si encuentra una categoría, ésta queda seleccionada, pudiendo
            ser modificada por el usuario. Si no encuentra ninguna categoría, o
            encuentra más de una, la selección queda vacía para que el usuario elija
            manualmente. La descripción tiene entre 3 y 20 caracteres. El monto debe
            ser un número mayor a cero, con dos decimales. La fecha se selecciona en
            un calendario, y debe estar comprendida entre el 01/01/2018 y el 31/12/2030.
            La categoría no puede quedar vacía.
       
            Gasto Comun: 

        Al crear el elemento expenses se le asigna un monto, descripcion, fecha, categoria.
        Si la descripcion tiene que entre 3-20 caracteres deberia ser true, sino false.
        El monto devuelve true si tiene dos decimales y es mayor a cero. 
        La fecha tiene que ir entre e el 01/01/2018 y el 31/12/2030.
        La categoria no puede ser empty.
     *   Al ingresar una descripcion se buscan las palabras claves de categoria y se le asigna esta un gasto. 
     *   Si no encuentra una palabra clave no le asigna una categoria automaticamente.
     *   
     */
    [TestClass]
    public class Gasto
    {
        [TestMethod]
        public void CrearGastoPorDefectoPrueba()
        {
            obligatorio1.Gasto gasto = new obligatorio1.Gasto() { Monto = 0, Descripcion= "No hay descripcion", Fecha = "xx/xx/xxxx", Categoria = null};
            int monto = 0;
            Assert.AreEqual(monto ,gasto.Monto);
            string descripcion = "No hay descripcion";
            Assert.AreEqual(descripcion, gasto.Descripcion);
            string fecha = "xx/xx/xxxx";
            Assert.AreEqual(fecha, gasto.Fecha);
            //Assert.AreEqual(categoria.IsEmpty(),gasto.categoria);

        }
      /*  [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void DescripcionPrueba()
        {
            obligatorio1.Gasto gasto = new obligatorio1.Gasto() { Monto = 0, Descripcion = "No hay descripcion", Fecha = "xx/xx/xxxx"};
            gasto.ValidarDescripcion(gasto.Descripcion);


        }*/
    }

  
}
