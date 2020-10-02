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
            if (listaCategorias.Contains(unaCategoria))
            {
                throw new InvalidOperationException();
                
            }
            else this.listaCategorias.Add(unaCategoria);
        }


        public void EliminarCategoria(Categoria unaCategoria)
        {
            this.listaCategorias.Remove(unaCategoria);
        }

        //consulta como 
        public Categoria BuscarPalabraClave(String unaPalabra)
        {
            String palabraMayuscula = unaPalabra.ToUpper();

            foreach (Categoria unaCategoria in listaCategorias)
            {
                if (unaCategoria.GetListaPClave().Contains(palabraMayuscula))
                {
                    return unaCategoria;
                }
                
            }

            throw new InvalidOperationException("No esta la palabra clave");

        }


        

    }
}