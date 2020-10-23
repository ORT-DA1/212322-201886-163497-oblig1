using Dominio;
using System;

namespace obligatorio1
{
    public class AdministradorPresupuesto
    {
        private Repositorio Repositorio { get; }
        public AdministradorPresupuesto()
        {
            this.Repositorio = new Repositorio();
        }
        public object RetornarListaPresupuestos()
        {
            return Repositorio.RetornarListaPresupuestos();
        }
    }
}