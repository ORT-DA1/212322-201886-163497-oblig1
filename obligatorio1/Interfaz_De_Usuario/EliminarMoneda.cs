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
using Excepciones;

namespace Interfaz_De_Usuario
{
    public partial class EliminarMoneda : UserControl
    {
        private AdministradorMonedas adminMonedas;
        public EliminarMoneda(AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminMonedas = miAdminMonedas;
            CargarComboBoxMoneda();
        }

        private void CargarComboBoxMoneda()
        {
            cbMonedas.DataSource = adminMonedas.RetornarListaMonedas();

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(cbCategorias.Text);
                Moneda monedaSeleccionada = (Moneda)cbMonedas.SelectedItem;

                adminMonedas.BorrarMoneda(monedaSeleccionada);
                cbMonedas.DataSource = null;
                cbMonedas.DataSource = adminMonedas.RetornarListaMonedas();
                MessageBox.Show("Moneda eliminada con éxito. ");
            }

            catch (ExcepcionElementoNoExistente unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }
        
    }
    
    
}
