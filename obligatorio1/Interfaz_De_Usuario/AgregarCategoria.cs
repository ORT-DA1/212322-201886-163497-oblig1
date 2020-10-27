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

    public partial class AgregarCategoria : UserControl
    {
        private AdministradorCategorias adminCategorias;
        

        public AgregarCategoria(AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            adminCategorias = miAdminCategorias;
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
           
            try
            {
                Categoria categoria = new Categoria() { Nombre = tbNombre.Text };
                adminCategorias.AgregarCategoria(categoria);
                MessageBox.Show("Categoria " + tbNombre.Text + " ha sido creada con exito");
                tbNombre.Clear();
            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }

      
    }
}
