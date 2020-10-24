using Dominio;
using System;
using System.Collections.Generic;

namespace Dominio
{
    // UN PRESUPUESTO PLANIFICADO PARA CADA MES.
    /* UN MONTO PARA CADA CATEGORIA.
     * . Si se agrega una categoría luego de haber creado el
presupuesto, el valor para la categoría nueva será inicialmente cero,
pudiendo el usuario cambiarlo después
    */

    public class AdministradorPresupuesto
    {
        private Repositorio Repositorio { get; }
        public AdministradorPresupuesto()
        {
            this.Repositorio = new Repositorio();
        }
        public List<Presupuesto> RetornarListaPresupuestos()
        {
            return Repositorio.RetornarListaPresupuestos();
        }
        /*
        public void AgregarPresupuesto(Presupuesto unPresupuesto)
        {

            if (this.Repositorio.ExistePresupuesto(unPresupuesto))
            {
                throw new ExcepcionElementoRepetido("Presupuesto ya existente");

            }
            else Repositorio.AgregarPresupuesto(unPresupuesto);
        }

        */
    }
}