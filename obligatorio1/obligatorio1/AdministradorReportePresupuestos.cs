using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AdministradorReportePresupuestos
    {
        private Repositorio Repositorio { get; }
        public AdministradorReportePresupuestos(Repositorio unRepositorio)
        {
            this.Repositorio = unRepositorio;

        }

        public List<DateTime> AgregarYRetornalListaDeMesesDondeHayPresupuestosOrdenada()
        {
            this.AgregarMesesAnioDondeHayPresupuesto();
            Repositorio.RetornarListaMesesDondeHayPresupuesto().Sort();
            return Repositorio.RetornarListaMesesDondeHayPresupuesto();
        }
        public void AgregarMesesAnioDondeHayPresupuesto()
        {
            foreach (Presupuesto presu in Repositorio.RetornarListaPresupuestos())
            {
                DateTime fecha = ConvertirFechaDejarSoloAnioMes(presu);
                if (!Repositorio.RetornarListaMesesDondeHayPresupuesto().Contains(fecha))
                {
                    Repositorio.AgregarMesDondeHayPresupuesto(fecha);
                }
            }

        }

        public DateTime ConvertirFechaDejarSoloAnioMes(Presupuesto presupuesto)
        {
            return new DateTime(presupuesto.Fecha.Year, presupuesto.Fecha.Month, 1);

        }




    }
}


