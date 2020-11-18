using System;
using System.Collections.Generic;


namespace Dominio
{
    public class AdministradorReportePresupuestos
    {
        private IRepositorio Repositorio { get; }
        public AdministradorReportePresupuestos(IRepositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;
        }

        public List<DateTime> AgregarYRetornalListaDeMesesDondeHayPresupuestosOrdenada()
        {
            List<DateTime> ListaMesesDondeHayPresupuesto = new List<DateTime>();

            foreach (Presupuesto presu in Repositorio.RetornarListaPresupuestos())
            {
                DateTime fecha = ConvertirFechaDejarSoloAnioMes(presu);
                if (!ListaMesesDondeHayPresupuesto.Contains(fecha))
                {
                    ListaMesesDondeHayPresupuesto.Add(fecha);
                }
            }
            ListaMesesDondeHayPresupuesto.Sort();
            return ListaMesesDondeHayPresupuesto;


        }
  
        public DateTime ConvertirFechaDejarSoloAnioMes(Presupuesto presupuesto)
        {
            return new DateTime(presupuesto.Fecha.Year, presupuesto.Fecha.Month, 1);
        }


    }
}


