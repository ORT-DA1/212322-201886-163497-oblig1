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
    public partial class ModificarMoneda : UserControl
    {
        private AdministradorMonedas adminMonedas;
        public ModificarMoneda(AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminMonedas = miAdminMonedas;
            CargarComboBoxMoneda();
        }
        private void CargarComboBoxMoneda()
        {
            cbMonedas.DataSource = adminMonedas.RetornarListaMonedas();

        }

        

        private void btnModificarNombre_Click_1(object sender, EventArgs e)
        {
            try
            {
                Moneda monedaElegida = (Moneda)cbMonedas.SelectedItem;
                adminMonedas.ModificarNombreAMoneda(monedaElegida, tbNombre.Text);
                MessageBox.Show("Nombre " + tbNombre.Text + " modificado con éxito");
                tbNombre.Clear();
                cbMonedas.DataSource = null;
                CargarComboBoxMoneda();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarSimbolo_Click_1(object sender, EventArgs e)
        {
            try
            {
                Moneda monedaElegida = (Moneda)cbMonedas.SelectedItem;
                adminMonedas.ModificarSimboloAMoneda(monedaElegida, tbSimbolo.Text);
                MessageBox.Show("Simbolo " + tbSimbolo.Text + " modificado con éxito");
                tbSimbolo.Clear();
                cbMonedas.DataSource = null;
                CargarComboBoxMoneda();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarCotizacion_Click_1(object sender, EventArgs e)
        {
            try
            {
                Moneda monedaElegida = (Moneda)cbMonedas.SelectedItem;
                adminMonedas.ModificarCotizacionAMoneda(monedaElegida, (double)numCotizacion.Value);
                MessageBox.Show("Cotizacion " + numCotizacion.Text + " modificada con éxito");
                numCotizacion.Value = 0;
                // cbMonedas.DataSource = adminMonedas.RetornarListaMonedas();
                cbMonedas.DataSource = null;
                CargarComboBoxMoneda();

            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
