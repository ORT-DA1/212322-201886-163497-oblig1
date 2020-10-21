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
    public partial class AgregarCategoria : UserControl
    {
        private Sistema miSistema;
        public AgregarCategoria(Sistema unSistema)
        {
            InitializeComponent();
            miSistema = unSistema;
            CargarComboBoxPabrasClave();
        }

         private void CargarComboBoxPabrasClave()
        {
            miSistema.repositorio.AgregarPalabraClaveACategoria(cbPalabrasClave);
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            miSistema.repo.CrearYAgregarCategoria(tbNombre.Text);

        }
    }
}
