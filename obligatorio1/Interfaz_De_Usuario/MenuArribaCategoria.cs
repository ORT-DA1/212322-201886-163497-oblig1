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
    public partial class MenuArribaCategoria : UserControl
    {
        private AdministradorCategorias unAdminCategorias;
        public MenuArribaCategoria(AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            unAdminCategorias = miAdminCategorias;



        }

        private void btnAgregarCatMenuArriba_Click(object sender, EventArgs e)
        {
            panelNuevo.Controls.Clear();
            UserControl agregarCategoria = new AgregarCategoria(unAdminCategorias);
            panelNuevo.Controls.Add(agregarCategoria);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            panelNuevo.Controls.Clear();
            UserControl modificarCategoria = new ModificarCategoria(unAdminCategorias);
            panelNuevo.Controls.Add(modificarCategoria);
        }
    }
}
