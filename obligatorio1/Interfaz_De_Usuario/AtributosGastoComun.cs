using Dominio;
using Excepciones;
using System;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{

    public partial class AtributosGastoComun : UserControl
    {
        private AdministradorGastosComunes unAdminGastosComun;
        private AdministradorCategorias unAdminCategorias;
        private GastoComun gastoC;
        private AdministradorMonedas unAdminMonedas;
        public AtributosGastoComun(AdministradorGastosComunes miAdminGastoComun, String descripcion, 
                                   AdministradorCategorias miAdministradorCategorias,AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            unAdminGastosComun = miAdminGastoComun;
            unAdminCategorias = miAdministradorCategorias;
            unAdminMonedas = miAdminMonedas;
            gastoC = new GastoComun() { Descripcion = descripcion };
            CargarComboBoxCategoria(descripcion);
            CargarComboBoxMoneda();

        }
        private void CargarComboBoxMoneda()
        {
            cbMoneda.DataSource = unAdminMonedas.RetornarListaMonedas();
        }

        private void CargarComboBoxCategoria(String descripcion)
        {

            foreach (Categoria unaCategoria in unAdminCategorias.RetornarListaCategorias())
            {
                cbCategoria.Items.Add(unaCategoria);
            }
            try
            {
                Categoria cat = unAdminCategorias.RetornarCategoriaDeDescripcion(descripcion);
                cbCategoria.SelectedItem = cat;

            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException || unaExcepcion is InvalidOperationException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }

        private void btnAceptarGastoC_Click(object sender, EventArgs e)
        {
            if (cbCategoria.SelectedItem == null)
            {
                MessageBox.Show("La Categoria no puede quedar vacia");
                return;
            }
            if (cbMoneda.SelectedItem == null)
            {
                MessageBox.Show("La Moneda no puede quedar vacia");
                return;
            }

            try
            {
                gastoC.Monto = (double)numMonto.Value;
                //unAdminGastosComun.AgregarMontoEnPesos(gastoC);
                gastoC.Fecha = dtFecha.Value;
                gastoC.Categoria = (Categoria)cbCategoria.SelectedItem;
                gastoC.Moneda = (Moneda)cbMoneda.SelectedItem;
                unAdminGastosComun.AgregarGastoComun(gastoC);
                
                MessageBox.Show("El gasto ha sido creado con exito ");

            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
