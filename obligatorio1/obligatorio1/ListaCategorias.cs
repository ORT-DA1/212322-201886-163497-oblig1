using Dominio;
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class ListaCategorias
    {
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
            this.listaCategorias.Add(unaCategoria);
        }


        public void EliminarCategoria(Categoria unaCategoria)
        {
            this.listaCategorias.Remove(unaCategoria);
        }

        //consulta como 
        public Categoria BuscarPalabraClave(String unaPalabra)
        {
            

            foreach (Categoria unaCategoria in listaCategorias)
            {
                if (unaCategoria.GetListaPClave.Contains(unaPalabra))
                {
                    return unaCategoria;
                }
                //else quiero que siga
            }

           // Categoria cat = new Categoria() { Nombre = "Entretenimiento" };
           // return cat;
        }


      

    }
}