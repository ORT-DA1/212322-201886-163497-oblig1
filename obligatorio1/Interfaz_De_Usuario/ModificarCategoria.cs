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
            
                String Categoria = cbCategorias.Text;
                Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(Categoria);
                AdminCategorias.AgregarPalabraClaveACategoria(categoriaSeleccionada, tbPalabraClave.Text);
                //cbListaPalabrasClave.Items.Clear();
                cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;


            //MessageBox.Show("Lista palabras clave: "+miRepositorio.RetornarPalabrasClaveDeCategoria(categoriaSeleccionada));
            //MessageBox.Show("Palabra clave agregada con exito");



        }

        private void cbCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {
            String Categoria = cbCategorias.Text;
            Categoria categoriaSeleccionada = AdminCategorias.RetornarCategoriaSegunString(Categoria);
            // cbListaPalabrasClave.DataSource = miRepositorio.RetornarPalabrasClaveDeCategoria(categoriaSeleccionada);
            cbListaPalabrasClave.DataSource = categoriaSeleccionada.PalabrasClave;

        }




        /* String Categoria = cbCategorias.Text;
         Categoria categoriaSeleccionada = miRepositorio.RetornarCategoriaSegunString(Categoria);
         cbListaPalabrasClave.DataSource = miRepositorio.RetornarPalabrasClaveDeCategoria(categoriaSeleccionada);
 */
    }
}
