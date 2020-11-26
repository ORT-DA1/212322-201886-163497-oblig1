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
    public partial class MenuArribaMoneda : UserControl
    {
        private AdministradorMonedas miAdminMonedas;
        public MenuArribaMoneda(AdministradorMonedas unAdminMonedas)
        {
            InitializeComponent();
            miAdminMonedas = unAdminMonedas;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            panelNuevo.Controls.Clear();
            UserControl agregarMoneda = new AgregarMoneda(miAdminMonedas);
            panelNuevo.Controls.Add(agregarMoneda);
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelNuevo.Controls.Clear();
            UserControl modificarMoneda = new ModificarMoneda(miAdminMonedas);
            panelNuevo.Controls.Add(modificarMoneda);
        }
        private void btnEliminarMoneda_Click(object sender, EventArgs e)
        {
            panelNuevo.Controls.Clear();
            UserControl eliminarMoneda = new EliminarMoneda(miAdminMonedas);
            panelNuevo.Controls.Add(eliminarMoneda);
        }
    }
}
