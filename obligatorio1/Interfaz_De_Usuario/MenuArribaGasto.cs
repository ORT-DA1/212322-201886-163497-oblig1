using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class MenuArribaGasto : UserControl
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        private AdministradorMonedas adminMonedas;
        public MenuArribaGasto(AdministradorGastosComunes miAdminGastosComunes, AdministradorCategorias miAdministradorCategorias,AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminGastosComunes = miAdminGastosComunes;
            adminCategorias = miAdministradorCategorias;
            adminMonedas = miAdminMonedas;
        }

        private void btnAgregarGastoC_Click(object sender, System.EventArgs e)
        {
            panelGastoComun.Controls.Clear();
            UserControl agregarCategoria = new AgregarGastoComun(adminGastosComunes, adminCategorias,adminMonedas);
            panelGastoComun.Controls.Add(agregarCategoria);
        }

        private void btnEliminar_Click(object sender, System.EventArgs e)
        {
            panelGastoComun.Controls.Clear();
            UserControl modificarGastoComun = new ModificarGastoComun(adminGastosComunes, adminCategorias,adminMonedas);
            panelGastoComun.Controls.Add(modificarGastoComun);
        }

        private void btnListadoGastos_Click(object sender, System.EventArgs e)
        {
            panelGastoComun.Controls.Clear();
            UserControl listadoGastos = new ListadoGastosComunes(adminGastosComunes);
            panelGastoComun.Controls.Add(listadoGastos);
            
        }
    }
}
