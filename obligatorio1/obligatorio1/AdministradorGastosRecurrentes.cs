using Excepciones;
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class AdministradorGastosRecurrentes
    {
        private IRepositorio Repositorio { get; }
        public AdministradorGastosRecurrentes(IRepositorio unRepositorio)
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
            else {
                AgregarMontoEnPesos(unGastoRecurrente);
                AsignarCotizacionOriginal(unGastoRecurrente);
                Repositorio.AgregarGastoRecurrente(unGastoRecurrente);
                
            } 

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

        public void AgregarMontoEnPesos(Gasto unGasto)
        {
            if (unGasto.Moneda.simbolo != "UYU")
            {
                unGasto.MontoEnPesos = unGasto.Monto * unGasto.Moneda.Cotizacion;
            }
            else
            {
                unGasto.MontoEnPesos = unGasto.Monto;
            }
        }

        public void ModificarDescripcion(GastoRecuerrente unGastoRecuerrente, string unaDescripcion)
        {
            Repositorio.ModificarDescripcionAGastoRecurrente(unGastoRecuerrente, unaDescripcion);
        }

        public void ModificarCategoria(GastoRecuerrente unGastoRecuerrente, Categoria otraCategoria)
        {
            Repositorio.ModificarCategoriaAGastoRecurrente(unGastoRecuerrente, otraCategoria);
        }

        public void ModificarDiaDelMes(GastoRecuerrente unGastoRecuerrente, int dia)
        {
            Repositorio.ModificarDiaDelMesAGastoRecurrente(unGastoRecuerrente, dia);
        }

        public void ModificarMonto(GastoRecuerrente unGastoRecuerrente, int monto)
        {
            Repositorio.ModificarMontoAGastoRecurrente(unGastoRecuerrente, monto);
        }

        public void ModificarMoneda(GastoRecuerrente unGastoRecuerrente, Moneda otraMoneda)
        {
            Repositorio.ModificarMonedaAGastoRecurrente(unGastoRecuerrente, otraMoneda);
        }

        public void AsignarCotizacionOriginal(GastoRecuerrente unGastoRecuerrente)
        {
            unGastoRecuerrente.CotizacionOriginalDeMoneda = unGastoRecuerrente.Moneda.Cotizacion;
        }


        public double RetornarCotizacionOriginal(GastoRecuerrente unGastoRecuerrente)
        {
            return unGastoRecuerrente.CotizacionOriginalDeMoneda;
        }
    }
}