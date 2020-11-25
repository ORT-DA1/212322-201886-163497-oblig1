using System;
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
        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
            cbListaPalabrasClave.DataSource = null;
            cbListaPalabrasClave.DataSource = AdminCategorias.RetornarPalabrasClaveDeCategoria(categoriaSeleccionada);
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
                PalabraClave palabraSeleccionada = (PalabraClave)cbListaPalabrasClave.SelectedItem;
                AdminCategorias.BorrarPalabraClaveACategoria(categoriaSeleccionada, palabraSeleccionada);
                cbListaPalabrasClave.DataSource = null;
                cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;
                MessageBox.Show("Palabra clave eliminada con exito");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Seleccione una categoria y una palabra clave para eliminarla");
            }

        }

     
    }
}
