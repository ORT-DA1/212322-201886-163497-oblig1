using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ReporteDeGastos : UserControl
    {
        private AdministradorGastosComunes adminGastoComun;
        private AdministradorGastosRecurrentes adminGastoRecurrente;

        public ReporteDeGastos(AdministradorGastosComunes AdminGastoComun, AdministradorGastosRecurrentes AdminGastoRecurrente)
        {
            InitializeComponent();
            adminGastoComun = AdminGastoComun;
            adminGastoRecurrente = AdminGastoRecurrente;
        }

    
    }
}
