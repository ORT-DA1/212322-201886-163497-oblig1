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
    public partial class ModificarMoneda : UserControl
    {
        private AdministradorMonedas adminMonedas;
        public ModificarMoneda(AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminMonedas = miAdminMonedas;
            CargarComboBoxMoneda();
        }
        private void CargarComboBoxMoneda()
        {
            cbMonedas.DataSource = adminMonedas.RetornarListaMonedas();

        }

        private void btnElegir_Click(object sender, EventArgs e)
        {
            Moneda monedaElegida = (Moneda)cbMonedas.SelectedItem;
            panelNuevo.Controls.Clear();
            UserControl agregarMoneda = new ModificarMonedaElegida(adminMonedas, monedaElegida);
            panelNuevo.Controls.Add(agregarMoneda);
        }
        
    }
}
