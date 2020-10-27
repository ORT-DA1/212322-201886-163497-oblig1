using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class MenuArribaGasto : UserControl
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;

        public MenuArribaGasto(AdministradorGastosComunes miAdminGastosComunes, AdministradorCategorias miAdministradorCategorias)
        {
            InitializeComponent();
            adminGastosComunes = miAdminGastosComunes;
            adminCategorias = miAdministradorCategorias;
        }

        private void btnAgregarGastoC_Click(object sender, System.EventArgs e)
        {
            panelGastoComun.Controls.Clear();
            UserControl agregarCategoria = new AgregarGastoComun(adminGastosComunes, adminCategorias);
            panelGastoComun.Controls.Add(agregarCategoria);
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            panelGastoComun.Controls.Clear();
            UserControl eliminarGastoComun = new EliminarGastoComun(adminGastosComunes);
            panelGastoComun.Controls.Add(eliminarGastoComun);
        }
    }
}
