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
            if (unAdminGastoComun.RetornarListaGastosComunes().Count != 0) CargarComboBox();
            else ComboBoxVacio();
        }
        public void CargarComboBox()
        {
            cbMoneda.DataSource = unAdminMonedas.RetornarListaMonedas();
            cbGastoComun.DataSource = unAdminGastoComun.RetornarListaGastosComunes();
            cbCategoria.DataSource = unAdminCategorias.RetornarListaCategorias();
        }
        public void ComboBoxVacio()
        {

            cbGastoComun.Text = "- Ningun gasto para eliminar -";
            btnEliminar.Visible = false;
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
                MessageBox.Show("Gasto eliminado con éxito");

            }
            catch (Exception unaExcepcion)
            {
                
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

       /* private void cbGastoComun_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                GastoComun gastoAmodificar = (GastoComun)cbGastoComun.SelectedItem;
                tbDescripcion.Text = gastoAmodificar.Descripcion;
                cbMoneda.SelectedItem = gastoAmodificar.Moneda.ToString();
                numMonto.Value = (decimal)gastoAmodificar.Monto;
                dtFecha.Value = gastoAmodificar.Fecha;
                cbCategoria.SelectedItem = gastoAmodificar.Categoria.ToString();
                
            }
            catch (Exception unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }*/
    }
}
