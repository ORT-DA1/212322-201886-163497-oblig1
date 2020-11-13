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
            try
            {
                Moneda moneda = new Moneda() { Nombre = tbNombre.Text, simbolo = tbSimbolo.Text, Cotizacion = (double)numCotizacion.Value };
                adminMonedas.AgregarMoneda(moneda);
                MessageBox.Show("Moneda " + tbNombre.Text + " ha sido creada con exito");
                tbNombre.Clear();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
