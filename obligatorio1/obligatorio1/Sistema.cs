using System;
using System.Collections.Generic;
using System.Linq;
using Excepciones;

namespace Dominio
{
    public class Sistema
    {
        public Repositorio repositorio { get; set; }
        public Sistema()
        {
            this.repositorio = new Repositorio();
        }

    }
}