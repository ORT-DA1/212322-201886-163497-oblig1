
using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones;

namespace Dominio
{
    public class Repositorio
    {
        private const char SEPARADOR = ' ';
      
        private List<Categoria> ListaCategorias { get; }


        public Repositorio()
        {
            this.ListaCategorias = new List<Categoria>();
            //var cantidad = this.GetAll().Count<Categoria>();
        }

       

        //Esto va en mi repositorio para acceder a todas las listas
        public List<Categoria> RetornarListaCategorias()
        {
            return this.ListaCategorias;
            //return new List<Categoria>();
        }




        // A PARTIR DE ACA ES LO QUE ESTABA ANTES
      

        public void EliminarCategoria(Categoria unaCategoria)
        {
            this.ListaCategorias.Remove(unaCategoria);
        }

        
        public Categoria CategoriaDePalabraClave(String palabraClave)
        {
            
            foreach (Categoria unaCategoria in ListaCategorias)
            {

                if (unaCategoria.ExistePalabraClave(palabraClave))
                {
                    return unaCategoria;
                }


            }

            throw new ExcepcionElementoNoExistente("No esta la palabra clave");

        }

         public bool PalabraClaveYaIngresadaEnAlgunaLista(string palabreClave)
         {
             foreach (Categoria unaCategoria in ListaCategorias)
             {  
                 if (unaCategoria.ExistePalabraClave(palabreClave))
                 {
                     return true;
                 }
             }
             return false;
          }
 
       

            private string[] SepararPalabras(string descripcion)
        {
            return descripcion.Split(SEPARADOR);
        }



        public Categoria RetornarCategoriaDeDescripcion(string descripcion)
        {
            if (CantDeCategoriasDistintasDondeApareceLaDescripcion(descripcion) > 1)
            {
                throw new InvalidOperationException("Hay varias palabras clave");
            }

            else
            {
                string[] palabras = SepararPalabras(descripcion);


                return this.BuscarCategoriaPorPalabras(palabras);

            }

        }

        internal Categoria BuscarCategoriaPorPalabras(string[] algunasPalabras)
        {
             foreach (string unaPalabra in algunasPalabras)
            {
                foreach (Categoria unaCategoria in ListaCategorias)
                {
                    if (unaCategoria.ExistePalabraClave(unaPalabra))
                    {
                        return unaCategoria;
                    }
                   
                }
            }
            throw new ExcepcionElementoNoExistente("Ninguna de las palabras es palabra clave");
        }


        public int CantDeCategoriasDistintasDondeApareceLaDescripcion(string descripcion)
        {
            int cantDeCategoriasDistintas = 0;
            string[] palabras = SepararPalabras(descripcion);
            Categoria categoriaYaContada = new Categoria();

            foreach (String palabra in palabras)
            {
                foreach (Categoria unaCategoria in ListaCategorias)
                {
                    if (unaCategoria.ExistePalabraClave(palabra))
                    {
                        // si es la primera vuelta, guardarCategoria va a ser distinta a unaCategoria
                        // en la segunda vuelta si es la misma categoria no entra aqui y no suma cant
                        if (LaCategoriaEsDistinta(unaCategoria, categoriaYaContada))
                        {
                            cantDeCategoriasDistintas++;
                            categoriaYaContada = unaCategoria;
                            
                        }

                    }
                }
            }

            return cantDeCategoriasDistintas;

        }


       private bool LaCategoriaEsDistinta (Categoria unaCategoria, Categoria otraCategoria)
        {
            if (!unaCategoria.Equals(otraCategoria))
            {
                return true;
            }
            else return false;
        }

        public void CrearYAgregarCategoria(String nombre)
        {
            Categoria categoria = new Categoria() { Nombre = nombre };
            this.AgregarCategoria(categoria);
        }

        public void AgregarPalabraClaveACategoria(Categoria categoria, string unaPalabra)
        {

            if (this.PalabraClaveYaIngresadaEnAlgunaLista(unaPalabra))
            {
                throw new InvalidOperationException();
            }
            categoria.AgregarPalabraClave(unaPalabra);
          
        }

        public void BorrarPalabraClaveACategoria(Categoria categoria, String palabra)
        {
            categoria.BorrarPalabraClave(palabra);
            
        }

        private string PasarAMayuscula(string unaPalabra)
        {
            return unaPalabra.ToUpper();
        }

    }
}