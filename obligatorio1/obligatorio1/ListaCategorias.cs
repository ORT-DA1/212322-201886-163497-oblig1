using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Dominio
{
    public class ListaCategorias
    {
        private const char SEPARADOR = ' ';
        private List<Categoria> listaCategorias { get; }

        public ListaCategorias()
        {
            this.listaCategorias = new List<Categoria>(); 
        }

        public bool EsVacia()
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

        
        public Categoria RetornarCategoriaDePalabraClave(String palabraClave)
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

        // NUEVO

        public int CantDeCategoriasDondeApareceLaDescripcion(string descripcion)
        {
            string[] palabras = SepararPalabras(descripcion);

            int cantidadDeVeces = 0;

            foreach (string pal in palabras)
            {


                if (PalabraClaveYaIngresadaEnAlgunaLista(pal))
                {
                    cantidadDeVeces++;
                }
            }

            return cantidadDeVeces;

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




        /* public bool ExistePalabraClave(string palabraMayuscula, Categoria unaCategoria)
         {
             return unaCategoria.GetListaPClave().Contains(palabraMayuscula);
         }*/

        /* private string PasarAMayuscula(string unaPalabra)
         {
             return unaPalabra.ToUpper();
         }*/



    }
}