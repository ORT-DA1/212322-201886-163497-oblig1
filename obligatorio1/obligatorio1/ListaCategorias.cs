using Dominio;
using System;
using System.Collections.Generic;
using System.Diagnostics;

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
                if (ExistePalabraClave (PasarAMayuscula(palabraClave), unaCategoria))
                {
                    return unaCategoria;
                }

            }

            throw new InvalidOperationException("No esta la palabra clave");

        }

        private bool ExistePalabraClave(string palabraMayuscula, Categoria unaCategoria)
        {
            return unaCategoria.GetListaPClave().Contains(palabraMayuscula);
        }

        private string PasarAMayuscula(string unaPalabra)
        {
            return unaPalabra.ToUpper();
        }



    }
}