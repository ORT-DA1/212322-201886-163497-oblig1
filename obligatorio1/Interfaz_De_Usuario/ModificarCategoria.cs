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
    public partial class ModificarCategoria : UserControl
    {
        private AdministradorCategorias AdminCategorias;
        public ModificarCategoria(AdministradorCategorias unAdminCategorias)
        {
            InitializeComponent();
            AdminCategorias = unAdminCategorias;
            CargarComboBoxCategoria();
            
        }

        private void CargarComboBoxCategoria()
        {
            cbCategorias.DataSource = AdminCategorias.RetornarListaCategorias();  
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            try
            {
                Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(cbCategorias.Text);
                AdminCategorias.AgregarPalabraClaveACategoria(categoriaSeleccionada, tbPalabraClave.Text);
                cbListaPalabrasClave.DataSource = null;
                cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;

            }
            catch(InvalidOperationException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            } 
            


        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(cbCategorias.Text);
            cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(cbCategorias.Text);
            
            AdminCategorias.BorrarPalabraClaveACategoria(categoriaSeleccionada, cbListaPalabrasClave.Text);

            cbListaPalabrasClave.DataSource = null;
            cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;
        }
     
    }
}
