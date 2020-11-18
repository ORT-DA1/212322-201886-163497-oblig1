using Excepciones;
using System.Collections.Generic;

namespace Dominio
{
    public class AdministradorPresupuesto
    {
        private IRepositorio Repositorio { get; }
        public AdministradorPresupuesto(IRepositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }
        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
            if (NoExiste(unPresupuesto))
            {
                Repositorio.AgregarPresupuesto(unPresupuesto);

                foreach (Categoria cat in Repositorio.RetornarListaCategorias())
                {
                    unPresupuesto.AgregarCategoriaMonto(cat, 0);
                }
                
            }
            else
            {
                throw new ExcepcionElementoRepetido("Ya existe un presupuesto para el mes elegido");
            }

        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            return Repositorio.RetornarListaPresupuestos();
        }

        private bool NoExiste(Presupuesto unPresupuesto)
        {
            return !Repositorio.ExisteUnPresupuesto(unPresupuesto.Fecha);
        }

        public void ModificarMontoACategoria(Presupuesto unPresupuesto, Categoria unaCategoria, int unMonto)
        {
            unPresupuesto.ModificarMontoACategoria(unaCategoria, unMonto);
        }

        public Presupuesto RetornarPresupuestoSegunMes(int unMes, int unAnio)
        {
            foreach (Presupuesto presupuesto in this.RetornarListaPresupuestos())
            {
                if (CoincideMesYAnio(unMes, unAnio, presupuesto))
                {
                    return presupuesto;
                }
            }
            throw new ExcepcionElementoNoExistente("No hay un presupuesto para el mes elegido");

        }

        private bool CoincideMesYAnio(int unMes, int unAnio, Presupuesto presupuesto)
        {
            return presupuesto.Fecha.Month == unMes && presupuesto.Fecha.Year == unAnio;
        }

    }
}