using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class PantallaPrincipal : Form
    { 

        public AdministradorCategorias AdminCategorias { get; set; }
        public AdministradorGastosComunes AdminGastoComun { get; set; }

        public AdministradorGastosRecurrentes AdminGastoRecurrente { get; set; }
        public PantallaPrincipal()
        {
            InitializeComponent();
            AdminCategorias = new AdministradorCategorias();
            AdminGastoComun = new AdministradorGastosComunes();
            AdminGastoRecurrente = new AdministradorGastosRecurrentes();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl modificarCategoria = new ModificarCategoria(AdminCategorias);
            panelPrincipal.Controls.Add(modificarCategoria);
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarCategoria = new AgregarCategoria(AdminCategorias);
            panelPrincipal.Controls.Add(agregarCategoria);
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarGastoComun = new AgregarGastoComun(AdminGastoComun,AdminCategorias);
            panelPrincipal.Controls.Add(agregarGastoComun);
        }

        private void btnAgregarGastoRecurrente_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarGastoRecurrente = new AgregarGastoRecurrente(AdminGastoRecurrente, AdminCategorias);
            panelPrincipal.Controls.Add(agregarGastoRecurrente);
        }
    }
}
