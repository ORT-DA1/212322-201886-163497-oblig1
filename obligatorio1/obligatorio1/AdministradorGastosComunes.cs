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

        public AdministradorGastosComunes(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;

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

        public void EliminarGastoComun(GastoComun unGastoComun)
        {
            Repositorio.EliminarGastoComun(unGastoComun);
        }

        public List<GastoComun> DevolverListaDeGastosSegunFecha(DateTime unaFecha)
        {
            throw new NotImplementedException();
        }
    }
}