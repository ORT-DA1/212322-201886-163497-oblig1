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

        public Sistema MiSistema { get; set; }

        public PantallaPrincipal()
        {
            InitializeComponent();
            MiSistema = new Sistema();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl modificarCategoria = new ModificarCategoria(MiSistema);
            panelPrincipal.Controls.Add(modificarCategoria);
        }
    }
}
