using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ModificarGastoComun : UserControl
    {
        private AdministradorGastosComunes unAdminGastoComun;
        private AdministradorCategorias unAdminCategorias;
        private AdministradorMonedas unAdminMonedas;

        public ModificarGastoComun(AdministradorGastosComunes miAdminGastoComun, AdministradorCategorias miAdminCategorias,
                                        AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            unAdminGastoComun = miAdminGastoComun;
            unAdminCategorias = miAdminCategorias;
            unAdminMonedas = miAdminMonedas;
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            cbMoneda.DataSource = unAdminMonedas.RetornarListaMonedas();
            cbGastoComun.DataSource = unAdminGastoComun.RetornarListaGastosComunes();
            cbCategoria.DataSource = unAdminCategorias.RetornarListaCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            VerificarSiElCampocbGastoComunEsVacio();
            try
            {
                GastoComun gastoEliminar = (GastoComun)cbGastoComun.SelectedItem;
                unAdminGastoComun.EliminarGastoComun(gastoEliminar);
                cbGastoComun.DataSource = null;
                cbGastoComun.DataSource = unAdminGastoComun.RetornarListaGastosComunes();

            }
            catch (Exception unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void VerificarSiElCampocbGastoComunEsVacio()
        {
            if (cbGastoComun.SelectedItem == null)
            {
                MessageBox.Show("Seleccione un gasto a eliminar");
            }
        }

        private void btnModificarGasto_Click(object sender, EventArgs e)
        {
            if (HayCamposVacios())
            {
                MessageBox.Show("Categoria y Descripción no pueden quedar vacias");
                return;
            }

            GastoComun gastoAmodificar = (GastoComun)cbGastoComun.SelectedItem;
            gastoAmodificar.Descripcion = tbDescripcion.Text;
            gastoAmodificar.Moneda =(Moneda)cbMoneda.SelectedItem;
            gastoAmodificar.Monto = (double)numMonto.Value;
            gastoAmodificar.Fecha = dtFecha.Value;
            gastoAmodificar.Categoria = (Categoria)cbCategoria.SelectedItem;
            unAdminGastoComun.ModificarGasto(gastoAmodificar);

            MessageBox.Show("El gasto ha modificado con exito ");

        }

        private bool HayCamposVacios()
        {
            return cbGastoComun.SelectedItem == null || string.IsNullOrEmpty(tbDescripcion.Text);
        }
    }
}
