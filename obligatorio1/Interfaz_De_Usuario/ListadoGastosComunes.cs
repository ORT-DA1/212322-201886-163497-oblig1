using Dominio;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class ListadoGastosComunes : UserControl
    {

        private AdministradorGastosComunes unAdminGastoComun;
        public ListadoGastosComunes(AdministradorGastosComunes miAdminGastoComun)
        {
            unAdminGastoComun = miAdminGastoComun;
            if (unAdminGastoComun.RetornarListaGastosComunes().Count == 0) MessageBox.Show("No hay gastos comunes por el momento");
            else
            {
                InitializeComponent();            
                CargarListaGastosComunes();
            }
        }
        public void CargarListaGastosComunes()
        {
             lstGastosComunes.DataSource = unAdminGastoComun.RetornarListaGastosComunes();
        }
    }
}
