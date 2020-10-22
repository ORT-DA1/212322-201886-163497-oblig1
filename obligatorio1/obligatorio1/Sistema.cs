using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones;


namespace Dominio
{
    public class Sistema
    {
        public Repositorio Repositorio { get; set; }
        public Sistema()
        {
            Repositorio = new Repositorio();
        }

        public void CrearYAgregarCategoria (String nombre)
        {
            Repositorio.CrearYAgregarCategoria(nombre);
        }

    }
}