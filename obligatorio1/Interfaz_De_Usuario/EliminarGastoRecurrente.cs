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
    public partial class EliminarGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastoRecurrente;
        public EliminarGastoRecurrente(AdministradorGastosRecurrentes miAdminGastoRecurrente)
        {
            InitializeComponent();
            unAdminGastoRecurrente = miAdminGastoRecurrente;
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            cbGastoRecurrente.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoEliminar = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                unAdminGastoRecurrente.EliminarGastoRecurrente(gastoEliminar);
                cbGastoRecurrente.DataSource = null;
                cbGastoRecurrente.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();

            }
            catch (Exception unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
