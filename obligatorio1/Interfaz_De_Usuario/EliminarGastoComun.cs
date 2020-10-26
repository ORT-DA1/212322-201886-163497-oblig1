using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class EliminarGastoComun : UserControl
    {
        private AdministradorGastosComunes unAdminGastoComun;

        public EliminarGastoComun(AdministradorGastosComunes miAdminGastoComun)
        {
            InitializeComponent();
            unAdminGastoComun = miAdminGastoComun;
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            cbGastoComun.DataSource = unAdminGastoComun.RetornarListaGastosComunes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                GastoComun gastoEliminar = (GastoComun)cbGastoComun.SelectedItem;
                unAdminGastoComun.EliminarGastoComun(gastoEliminar);
                cbGastoComun.DataSource = null;
                cbGastoComun.DataSource = unAdminGastoComun.RetornarListaGastosComunes();

            }
            catch (Exception unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
