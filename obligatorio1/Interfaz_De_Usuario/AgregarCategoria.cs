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
        private Repositorio miRepostorio;
        public AgregarCategoria(Repositorio unRepositorio)
        {
            InitializeComponent();
            miRepostorio = unRepositorio;
            CargarComboBoxPabrasClave();
        }

        private void CargarComboBoxPabrasClave()
        {
            throw new NotImplementedException();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Categoria unaCategoria = new Categoria
            {
                Nombre = tbNombre.Text
            };
        }
    }
}
