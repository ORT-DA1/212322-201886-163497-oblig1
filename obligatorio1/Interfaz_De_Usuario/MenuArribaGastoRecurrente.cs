using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class MenuArribaGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private AdministradorCategorias adminCategorias;
        private AdministradorMonedas adminMonedas; 
        public MenuArribaGastoRecurrente(AdministradorGastosRecurrentes miAdminGastosRecurrentes, AdministradorCategorias miAdminCategorias, AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminCategorias = miAdminCategorias;
            adminGastosRecurrentes = miAdminGastosRecurrentes;
            adminMonedas = miAdminMonedas;
        }

        private void btnAgregarGastoRecurrente_Click(object sender, System.EventArgs e)
        {
            panelGRecurrente.Controls.Clear();
            UserControl agregarGastoRecurrente = new AgregarGastoRecurrente(adminGastosRecurrentes, adminCategorias, adminMonedas);
            panelGRecurrente.Controls.Add(agregarGastoRecurrente);
        }

        private void btnModificarGastoRecurrente_Click(object sender, System.EventArgs e)
        {
            panelGRecurrente.Controls.Clear();
            UserControl eliminarGastoRecurrente = new ModificarGastoRecurrente(adminGastosRecurrentes, adminCategorias, adminMonedas);
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
