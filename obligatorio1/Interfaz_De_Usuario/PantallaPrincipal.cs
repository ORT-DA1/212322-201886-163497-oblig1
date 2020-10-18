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
        
        public Administrador AdministradorPrincipal { get; set; }
        public PantallaPrincipal()
        {
            InitializeComponent();
            AdministradorPrincipal = new Administrador();
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarCategoria = new AgregarCategoria(AdministradorPrincipal);
            panelPrincipal.Controls.Add(agregarCategoria);
        }
    }
}
