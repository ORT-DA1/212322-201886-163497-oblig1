using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Excepciones;


namespace Dominio
{
    public class AdministradorGastosComunes
    {
        private Repositorio Repositorio { get; }

        public AdministradorGastosComunes()
        {
            this.Repositorio = new Repositorio();

        }

        public List<GastoComun> RetornarListaGastosComunes()
        {
            return Repositorio.RetornarListaGastosCoumnes();
        }

        public void AgregarGastoComun(GastoComun unGastoComun)
        {
            if (NoHayCategoriaDefinida(unGastoComun))
            {
                throw new ExcepcionElementoNoExistente("La categoria no puede quedar vacía");
            }
            else Repositorio.AgregarGastoComun(unGastoComun);

        }

        private bool NoHayCategoriaDefinida(GastoComun unGastoComun)
        {
            return unGastoComun.Categoria.Nombre == "No hay nombre";
        }

        public bool EsVaciaListaGastosComunes()
        {
            return Repositorio.EsVaciaListaGastosComunes();
        }




    }
}