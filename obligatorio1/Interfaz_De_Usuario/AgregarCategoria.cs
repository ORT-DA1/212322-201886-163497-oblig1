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
        private Repositorio miRepositorio;

        public AgregarCategoria(Repositorio unRepositorio)
        {
            InitializeComponent();
            miRepositorio = unRepositorio;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                miRepositorio.CrearYAgregarCategoria(tbNombre.Text);
                MessageBox.Show("Categoria " + tbNombre.Text + " ha sido creada con exito");
            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
           /* catch(ExcepcionPalabraLarga unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }*/
        }
    }
}
