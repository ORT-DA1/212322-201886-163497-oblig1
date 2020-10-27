using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class MenuArribaGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private AdministradorCategorias adminCategorias;
        public MenuArribaGastoRecurrente(AdministradorGastosRecurrentes miAdminGastosRecurrentes, AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            adminCategorias = miAdminCategorias;
            adminGastosRecurrentes = miAdminGastosRecurrentes;
        }

        private void btnAgregarGastoRecurrente_Click(object sender, System.EventArgs e)
        {
            panelGRecurrente.Controls.Clear();
            UserControl agregarGastoRecurrente = new AgregarGastoRecurrente(adminGastosRecurrentes, adminCategorias);
            panelGRecurrente.Controls.Add(agregarGastoRecurrente);
        }

        private void btnEliminarGRecurrente_Click(object sender, System.EventArgs e)
        {
            panelGRecurrente.Controls.Clear();
            UserControl eliminarGastoRecurrente = new EliminarGastoRecurrente(adminGastosRecurrentes);
            panelGRecurrente.Controls.Add(eliminarGastoRecurrente);
        }

        private void btnListadoGastos_Click(object sender, System.EventArgs e)
        {
            panelGRecurrente.Controls.Clear();
            UserControl listadoGastos = new ListadoGastosRecurrentes(adminGastosRecurrentes);
            panelGRecurrente.Controls.Add(listadoGastos);
        }
    }
}
