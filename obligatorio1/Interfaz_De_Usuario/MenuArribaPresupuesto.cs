using Dominio;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class MenuArribaPresupuesto : UserControl
    {
        private AdministradorPresupuesto adminPresupuestos;
        public MenuArribaPresupuesto(AdministradorPresupuesto miAdminPresupuestos, AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuestos;
            
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
            UserControl crearPresupuesto = new ModificarPresupuesto(adminPresupuestos);
            panelPresupuesto.Controls.Add(crearPresupuesto);
        }
    }
}
