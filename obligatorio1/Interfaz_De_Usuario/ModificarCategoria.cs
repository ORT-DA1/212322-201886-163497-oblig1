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

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (cbCategorias.SelectedItem == null || AdminCategorias.EsVaciaListaCategorias())
            {
                MessageBox.Show("Categoria y palabra clave no pueden ser vacias");
                return;
            }
            try
            {
                Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
                PalabraClave palabra = new PalabraClave() { Palabra = tbPalabraClave.Text };
               
                AdminCategorias.AgregarPalabraClaveACategoria(categoriaSeleccionada, palabra);

                
                /*cbListaPalabrasClave.DataSource = null;
                cbListaPalabrasClave.DataSource = AdminCategorias.RetornarPalabrasClaveDeCategoria(categoriaSeleccionada);*/

                MessageBox.Show("Palabra Clave agregada con exito");
                tbPalabraClave.Clear();
            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is InvalidOperationException || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                //Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(cbCategorias.Text);
                Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
                PalabraClave palabraSeleccionada = (PalabraClave)cbListaPalabrasClave.SelectedItem;
                AdminCategorias.BorrarPalabraClaveACategoria(categoriaSeleccionada, palabraSeleccionada);
                cbListaPalabrasClave.DataSource = null;
                cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;
            }

            catch (ExcepcionElementoNoExistente unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }

        private void btnBorrarCategoria_Click(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)cbCategorias.SelectedItem;
            AdminCategorias.EliminarCategoria(categoriaSeleccionada);
        }
    }
}
