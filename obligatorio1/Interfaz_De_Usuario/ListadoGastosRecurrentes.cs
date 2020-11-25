using Dominio;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class ListadoGastosRecurrentes : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastoRecurrente;
        public ListadoGastosRecurrentes(AdministradorGastosRecurrentes miAdminGastoRecurrente)
        {
            
            unAdminGastoRecurrente = miAdminGastoRecurrente;
            if (unAdminGastoRecurrente.RetornarListaGastosRecurrentes().Count == 0) MessageBox.Show("No hay gastos recurrentes por el momento");
            else
            {
                InitializeComponent();
                CargarListaGastosRecurrentes();
            }
            
        }

        public void CargarListaGastosRecurrentes()
        {
            lstGastosRecurrentes.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();
        }
    }
}
