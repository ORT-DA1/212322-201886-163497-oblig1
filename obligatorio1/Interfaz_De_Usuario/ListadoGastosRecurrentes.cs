using Dominio;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class ListadoGastosRecurrentes : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastoRecurrente;
        public ListadoGastosRecurrentes(AdministradorGastosRecurrentes miAdminGastoRecurrente)
        {
            InitializeComponent();
            unAdminGastoRecurrente = miAdminGastoRecurrente;
            CargarListaGastosComunes();
        }

        public void CargarListaGastosComunes()
        {
            lstGastosRecurrentes.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();
        }
    }
}
