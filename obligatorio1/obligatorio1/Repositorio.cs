
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Dominio
{
    public class Repositorio
    {
        private const char SEPARADOR = ' ';
      
        public List<Categoria> ListaCategorias { get; }


        public Repositorio()
        {
            this.ListaCategorias = new List<Categoria>();
          
        }

        // METODOS DE LISTAS CATEGORIAS
        public bool EsVaciaListaCategorias()
        {
            return ListaCategorias.Count == 0;
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {
            
            if (ExisteCategoria(unaCategoria))
            {
                throw new InvalidOperationException();
                
            }
            else this.ListaCategorias.Add(unaCategoria);
        }

        private bool ExisteCategoria(Categoria unaCategoria)
        {
            return ListaCategorias.Contains(unaCategoria);
        }

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

            throw new InvalidOperationException("No esta la palabra clave");

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
            if (CantDeCategoriasDondeApareceLaDescripcion(descripcion) > 1)
            {
                throw new InvalidOperationException("Hay varias palabras clave");
            }

            else
            {
                string[] palabras = SepararPalabras(descripcion);

                foreach (string unaPalabra in palabras)
                {
                    foreach (Categoria unaCategoria in ListaCategorias)
                    {
                        if (unaCategoria.ExistePalabraClave(unaPalabra))
                        {
                            return unaCategoria;
                        }
                    }

                }

                throw new InvalidOperationException("Ninguna de las palabras es palabra clave");
    }

        }

     
        public int CantDeCategoriasDondeApareceLaDescripcion(string descripcion)
        {
            string[] palabras = SepararPalabras(descripcion);
            Categoria guardarCategoria = new Categoria();

            int cant = 0;
            foreach (String palabra in palabras)
            {
                foreach (Categoria unaCategoria in ListaCategorias)
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


        // NUEVO

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