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
        private Sistema miSistema;
        public ModificarCategoria(Sistema unSistema)
        {
            InitializeComponent();
            miSistema = unSistema;
            //CargarComboBoxPabrasClave();
        }

     /*   private void CargarComboBoxPabrasClave()
        {
            miSistema.Repositorio.AgregarPalabraClaveACategoria(tbNombre.Text,cbPalabrasClave.Text);  
        }*/

        private void btnAgregar_Click(object sender, EventArgs e)
        {

           /* try
            {
                miSistema.CrearYAgregarCategoria(tbNombre.Text);
                miSistema.Repositorio.AgregarPalabraClaveACategoria(tbNombre.Text, cbPalabrasClave.Text);
                MessageBox.Show("Categoria" + tbNombre.Text + "ha sido creada con exito");
            }
            catch (ExcepcionElementoRepetido unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }*/
            
        }

        
    }
}
