using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ReporteDeGastos : UserControl
    {
        private AdministradorGastosComunes adminGastoComun;
        private AdministradorGastosRecurrentes adminGastoRecurrente;
        private AdministradorReporteGastos adminReporteGastos;

        public ReporteDeGastos(AdministradorGastosComunes AdminGastoComun, AdministradorGastosRecurrentes AdminGastoRecurrente, AdministradorReporteGastos AdminReporteGastos)
        {
            InitializeComponent();
            adminGastoComun = AdminGastoComun;
            adminGastoRecurrente = AdminGastoRecurrente;
            adminReporteGastos = AdminReporteGastos;

            cbMesAnio.DataSource = adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada();
            /*foreach (DateTime unMesAnio in adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada())
            {
                cbMesAnio.Items.Add(unMesAnio);
            }*/
        }


        
    }
}
