
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Dominio
{
    public class Repositorio
    {
        private const char SEPARADOR = ' ';
        private List<Categoria> listaCategorias { get; }

        public Repositorio()
        {
            this.listaCategorias = new List<Categoria>(); 
        }






        // METODOS DE LISTAS CATEGORIAS
        public bool EsVaciaListaCategorias()
        {
            return listaCategorias.Count == 0;
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {
            
            if (ExisteCategoria(unaCategoria))
            {
                throw new InvalidOperationException();
                
            }
            else this.listaCategorias.Add(unaCategoria);
        }

        private bool ExisteCategoria(Categoria unaCategoria)
        {
            return listaCategorias.Contains(unaCategoria);
        }

        public void EliminarCategoria(Categoria unaCategoria)
        {
            this.listaCategorias.Remove(unaCategoria);
        }

        
        public Categoria CategoriaDePalabraClave(String palabraClave)
        {
            
            foreach (Categoria unaCategoria in listaCategorias)
            {

                if (unaCategoria.ExistePalabraClave(palabraClave))
                {
                    return unaCategoria;
                }


            }

            throw new InvalidOperationException("No esta la palabra clave");

        }

         public bool PalabraClaveYaIngresadaEnAlgunaLista(string palabreClave)
         {
             foreach (Categoria unaCategoria in listaCategorias)
             {
                 if (unaCategoria.ExistePalabraClave(palabreClave))
                 {
                     return true;
                 }
             }
             return false;
          }
 
        /* // NUEVO
         //Este metodo deberia retornar la cantidad de categorias distintas donde aparece la descripcion.
         public int CantDeCategoriasDondeApareceLaDescripcion(string descripcion)
         {
             string[] palabras = SepararPalabras(descripcion);

             int cantidadDeVeces = 0;
             //cine
             foreach (string pal in palabras)
             {


                 if (PalabraClaveYaIngresadaEnAlgunaLista(pal))
                 {
                     cantidadDeVeces++;
                 }
             }

             return cantidadDeVeces;

         }*/


       

            private string[] SepararPalabras(string descripcion)
        {
            return descripcion.Split(SEPARADOR);
        }


        // otra prueba  ARREGLADO

        public int CantDeCategoriasDondeApareceLaDescripcion(string descripcion)
        {
            string[] palabras = SepararPalabras(descripcion);
            Categoria guardarCategoria = new Categoria();

            int cant = 0;
            foreach (String palabra in palabras)
            {
                foreach (Categoria unaCategoria in listaCategorias)
                {
                    if (unaCategoria.ExistePalabraClave(palabra))
                    {

                        // si es la primera vuelta, guardarCategoria va a ser distinta a unaCategoria
                        // en la segunda vuelta si es la misma categoria no entra aqui y no suma cant
                        if (!guardarCategoria.Equals(unaCategoria))
                        {
                            guardarCategoria = unaCategoria;
                            cant++;
                        }


                    }
                }
            }

            return cant;

        }


        public Categoria RetornarCategoriaDeDescripcion(string descripcion)
        {
            if (CantDeCategoriasDondeApareceLaDescripcion(descripcion) > 1)
            {
                throw new InvalidOperationException("Hay varias palabras clave");
            }

            else
            {
                string[] palabras = SepararPalabras(descripcion);

                foreach (string pal in palabras)
                {
                    foreach (Categoria unaCategoria in listaCategorias)
                    {
                        if (unaCategoria.ExistePalabraClave(pal))
                        {
                            return unaCategoria;
                        }
                    }

                }

                throw new InvalidOperationException("Ninguna de las palabras es palabra clave");

            }


        }   






    }
}