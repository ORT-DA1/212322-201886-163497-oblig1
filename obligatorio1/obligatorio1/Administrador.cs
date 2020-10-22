using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones;


namespace Dominio
{
    public class Administrador
    {
        private Repositorio repositorio;

        public Administrador()
        {
            repositorio = new Repositorio();

        }

        // PASE ESTOS METODOS DE REPOSITORIO A ESTA CLASE
        public bool EsVaciaListaCategorias()
        {
            return repositorio.RetornarListaCategorias().Count == 0;
        }

        public void AgregarCategoria(Categoria unaCategoria)
        {

            if (repositorio.ExisteCategoria(unaCategoria))
            {
                throw new ExcepcionElementoRepetido();

            }
            else repositorio.RetornarListaCategorias().Add(unaCategoria);
        }

        /* 
          private bool ExisteCategoria(Categoria unaCategoria)
       {
           return repositorio.RetornarListaCategorias().Contains(unaCategoria);
       }
          */




    }
}