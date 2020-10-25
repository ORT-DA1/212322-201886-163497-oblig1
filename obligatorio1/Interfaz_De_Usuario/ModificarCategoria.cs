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
        public AdministradorCategorias unAdministrador { get; set; }
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
            if ( cbCategorias.SelectedItem == null || AdminCategorias.EsVaciaListaCategorias() )
            {
                MessageBox.Show("Categoria y palabra clave no pueden quedar vacias");
                return;
            }
            try
            {
                Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
                AdminCategorias.AgregarPalabraClaveACategoria(categoriaSeleccionada, tbPalabraClave.Text);
                cbListaPalabrasClave.DataSource = null;
                cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;
                MessageBox.Show("Palabra Clave agregada con exito");
                tbPalabraClave.Clear();
            }
            catch (Exception unaExcepcion)
            when(unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is InvalidOperationException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }


        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
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
