
using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Dominio
{
    public class Repositorio
    {
        private const char SEPARADOR = ' ';
      
        public List<Categoria> ListaCategorias { get; }

        public List<String> ListaDeTodasPalabrasClave { get; }
        


        public Repositorio()
        {
            this.ListaCategorias = new List<Categoria>();
            this.ListaDeTodasPalabrasClave = new List<string>();
          
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


        // otra prueba  ARREGLADO

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
                    foreach (Categoria unaCategoria in ListaCategorias)
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


        public bool EsVaciaListaTodasPalabrasClave()
        {
            return this.ListaDeTodasPalabrasClave.Count == 0;
        }

        public void AgregarAListaTodasPalabrasClave(Categoria categoria,string unaPalabra)
        {

            if (this.ExistePalabraEnListaTodasPalabrasClave(unaPalabra))
            {
                throw new InvalidOperationException();
            }
            this.ListaDeTodasPalabrasClave.Add(PasarAMayuscula(unaPalabra));
            AgregarPalabraClaveACategoria(categoria, unaPalabra);
        }

        
        private void AgregarPalabraClaveACategoria(Categoria categoria, string unaPalabra)
        {
            categoria.AgregarPalabraClave(unaPalabra);
        }
        


        public bool ExistePalabraEnListaTodasPalabrasClave(string unaPalabra)
        {
            return this.ListaDeTodasPalabrasClave.Contains(PasarAMayuscula(unaPalabra));
        }


       


        private string PasarAMayuscula(string unaPalabra)
        {
            return unaPalabra.ToUpper();
        }

    }
}