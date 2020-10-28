using Dominio;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class MenuArribaPresupuesto : UserControl
    {
        private AdministradorPresupuesto adminPresupuestos;
        private AdministradorReportePresupuestos adminReportePresupuestos;
        public MenuArribaPresupuesto(AdministradorPresupuesto miAdminPresupuestos, AdministradorCategorias miAdminCategorias, AdministradorReportePresupuestos miAdminReportePresupuestos)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuestos;
            adminReportePresupuestos = miAdminReportePresupuestos;


        }

        private void btnCrearPresupuesto_Click(object sender, System.EventArgs e)
        {
            panelPresupuesto.Controls.Clear();
            UserControl crearPresupuesto = new CrearPresupuesto(adminPresupuestos);
            panelPresupuesto.Controls.Add(crearPresupuesto);
        }

        private void btnModificarPresupuesto_Click(object sender, System.EventArgs e)
        {
            panelPresupuesto.Controls.Clear();
            UserControl crearPresupuesto = new ModificarPresupuesto(adminPresupuestos, adminReportePresupuestos);
            panelPresupuesto.Controls.Add(crearPresupuesto);
        }
    }
}
