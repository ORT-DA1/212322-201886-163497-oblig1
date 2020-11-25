using System;
using System.Windows.Forms;
using Dominio;
using Excepciones;

namespace Interfaz_De_Usuario
{

    public partial class AgregarCategoria : UserControl
    {
        private AdministradorCategorias adminCategorias;
        public AgregarCategoria(AdministradorCategorias miAdminCategorias)
        {   
            InitializeComponent();
            adminCategorias = miAdminCategorias;
            CargarListaCategorias();

        

        }
        public void CargarListaCategorias()
        {
            listCategorias.DataSource = null;
            listCategorias.DataSource = adminCategorias.RetornarListaCategorias();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           try
            {
                Categoria categoria = new Categoria() { Nombre = tbNombre.Text };
                adminCategorias.AgregarCategoria(categoria);
                MessageBox.Show("Categoria " + tbNombre.Text + " ha sido creada con exito");
                CargarListaCategorias();
                tbNombre.Clear();
                
            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }

        private void listCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            Categoria categoriaSeleccionada = (Categoria)listCategorias.SelectedItem;
            listPalabrasClave.DataSource = null;
            listPalabrasClave.DataSource = adminCategorias.RetornarPalabrasClaveDeCategoria(categoriaSeleccionada);
        }

        private void btnAgregarPClave_Click(object sender, EventArgs e)
        {
            try
            {
                Categoria categoriaSeleccionada = (Categoria)listCategorias.SelectedItem;
                PalabraClave palabra = new PalabraClave() { Palabra = tbPalabraClave.Text };

                adminCategorias.AgregarPalabraClaveACategoria(categoriaSeleccionada, palabra);
                listPalabrasClave.DataSource = null;
                listPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;

                MessageBox.Show("Palabra Clave agregada con exito");
                tbPalabraClave.Clear();
            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is InvalidOperationException || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
