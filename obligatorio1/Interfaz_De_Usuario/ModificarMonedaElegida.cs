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
    
    public partial class ModificarMonedaElegida : UserControl
    {
        private AdministradorMonedas adminMonedas;
        private Moneda monedaElegida;
        public ModificarMonedaElegida(AdministradorMonedas miAdminMonedas, Moneda miMonedaElegida)
        {
            adminMonedas = miAdminMonedas;
            miMonedaElegida = monedaElegida;
            InitializeComponent();
        }

        private void btnModificarNombre_Click(object sender, EventArgs e)
        {
           // try
            //{
                adminMonedas.ModificarNombreAMoneda(this.monedaElegida, tbNombre.Text);
                MessageBox.Show("Nombre " + tbNombre.Text + " modificado con éxito");
                tbNombre.Clear();
            //}
            //catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            //{
               // MessageBox.Show(unaExcepcion.Message);
            //}
        }
    }
}
