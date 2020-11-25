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
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class AgregarMoneda : UserControl
    {
        private AdministradorMonedas adminMonedas;
        public AgregarMoneda(AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminMonedas = miAdminMonedas;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbNombre.Text) || String.IsNullOrEmpty(tbSimbolo.Text))
            {
                MessageBox.Show("Hay campos vacíos.");
                return;
            }
            try
            {
                Moneda moneda = new Moneda() { Nombre = tbNombre.Text, Simbolo = tbSimbolo.Text, Cotizacion = (double)numCotizacion.Value };
                adminMonedas.AgregarMoneda(moneda);
                MessageBox.Show("Moneda " + tbNombre.Text + " ha sido creada con exito");
                tbNombre.Clear();
            }
            catch (Exception unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
