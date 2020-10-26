using Excepciones;
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class AdministradorGastosRecurrentes
    {
        private Repositorio Repositorio { get; }
        public AdministradorGastosRecurrentes(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;

        }

        public List<GastoRecuerrente> RetornarListaGastosRecurrentes()
        {
            return Repositorio.RetornarListaGastosRecurrentes();
        }
        public void AgregarGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            if (NoHayCategoriaDefinida(unGastoRecurrente))
            {
                throw new ExcepcionElementoNoExistente("La categoria no puede quedar vacía");
            }
            else Repositorio.AgregarGastoRecurrente(unGastoRecurrente);

        }
        private bool NoHayCategoriaDefinida(GastoRecuerrente unGastoRecurrente)
        {
            return unGastoRecurrente.Categoria.Nombre == "No hay nombre";
        }

        public bool EsVaciaListaGastosRecurrentes()
        {
            return Repositorio.EsVaciaListaGastosRecurrentes();
        }

        public void EliminarGastoRecurrente(GastoRecuerrente unGastoRecurrente)
        {
            Repositorio.EliminarGastoRecuerrente(unGastoRecurrente);
        }


    }
}