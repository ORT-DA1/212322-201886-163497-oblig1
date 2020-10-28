using Dominio;
using Excepciones;
using System;
using System.Collections.Generic;

namespace Dominio
{
   

    public class AdministradorPresupuesto
    {
        private Repositorio Repositorio { get; }
        public AdministradorPresupuesto(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            return Repositorio.RetornarListaPresupuestos();
        }

        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {
            if (!Repositorio.ExisteUnPresupuesto(unPresupuesto.Fecha))
            {
                foreach (Categoria cat in Repositorio.RetornarListaCategorias())
                {
                    unPresupuesto.AgregarCategoriaMonto(cat, 0);
                }
                Repositorio.AgregarPresupuesto(unPresupuesto);
            }
            else
            {
                throw new ExcepcionElementoRepetido("Ya existe un presupuesto para el mes elegido");
            }


        }


        public void ModificarMontoACategoria(Presupuesto unPresupuesto, Categoria unaCategoria, int unMonto)
        {
            unPresupuesto.ModificarMontoACategoria(unaCategoria, unMonto);
        } 

        public Presupuesto RetornarPresupuestoSegunMes(int unMes, int unAnio)
        {
            foreach (Presupuesto p in this.RetornarListaPresupuestos())
            {
                if (p.Fecha.Month == unMes && p.Fecha.Year == unAnio)
                {
                    return p;
                }
            }
            throw new ExcepcionElementoNoExistente("No hay un presupuesto para el mes elegido");

        } 



    }
}