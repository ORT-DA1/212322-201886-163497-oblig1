using System.Collections.Generic;
using Excepciones;


namespace Dominio
{
    public class AdministradorGastosComunes
    {
        private IRepositorio Repositorio { get; }

        public AdministradorGastosComunes(IRepositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }

        public List<GastoComun> RetornarListaGastosComunes()
        {
            return Repositorio.RetornarListaGastosCoumnes();
        }

        public void AgregarGastoComun(GastoComun unGastoComun)
        {
            AgregarMontoEnPesos(unGastoComun);
            Repositorio.AgregarGastoComun(unGastoComun);
        }
    
        public bool EsVaciaListaGastosComunes()
        {
            return Repositorio.EsVaciaListaGastosComunes();
        }
        public void EliminarGastoComun(GastoComun unGastoComun)
        {
            Repositorio.EliminarGastoComun(unGastoComun);
        }
        public void AgregarMontoEnPesos(Gasto unGasto)
        {
            if(unGasto.Moneda.simbolo != "UYU")
            {
                unGasto.MontoEnPesos = unGasto.Monto * unGasto.Moneda.Cotizacion;
            }
            else
            {
                unGasto.MontoEnPesos = unGasto.Monto;
            }
        }
        public void ModificarGasto(GastoComun unGasto)
        {
            Repositorio.ModificarGasto(unGasto);
        }    
    }
}