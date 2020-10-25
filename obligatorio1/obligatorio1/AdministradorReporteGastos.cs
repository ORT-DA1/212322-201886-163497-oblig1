using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;


namespace Dominio
{
    public class AdministradorReporteGastos
    {
        private AdministradorGastosComunes administradorGastosComunes;
        public AdministradorReporteGastos()
        {
            administradorGastosComunes = new AdministradorGastosComunes();

        }

        public List<GastoComun> RetornarListaGastosDelMes()
        {
            throw new NotImplementedException();
        }
    }
}