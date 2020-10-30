using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ModificarGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastoRecurrente;
        private AdministradorCategorias unAdminCategorias;
        public ModificarGastoRecurrente(AdministradorGastosRecurrentes miAdminGastoRecurrente, AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            unAdminGastoRecurrente = miAdminGastoRecurrente;
            unAdminCategorias = miAdminCategorias;
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            cbGastoRecurrente.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();
            cbCategoria.DataSource = unAdminCategorias.RetornarListaCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoEliminar = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                unAdminGastoRecurrente.EliminarGastoRecurrente(gastoEliminar);
                cbGastoRecurrente.DataSource = null;
                cbGastoRecurrente.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();

            }
            catch (Exception unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarGasto_Click(object sender, EventArgs e)
        {
            if (HayCamposVacios())
            {
                MessageBox.Show("Categoria y Descripción no pueden quedar vacias");
                return;
            }
            try
            {
                GastoRecuerrente gastoAmodificar = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                gastoAmodificar.Descripcion = tbDescripcion.Text;
                gastoAmodificar.Monto = (double)numMonto.Value;
                gastoAmodificar.Fecha = (int)numFecha.Value;
                gastoAmodificar.Categoria = (Categoria)cbCategoria.SelectedItem;
                MessageBox.Show("El gasto ha modificado con exito ");
            }

            catch (IndexOutOfRangeException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
            
        }

        private bool HayCamposVacios()
        {
            return cbGastoRecurrente.SelectedItem == null || string.IsNullOrEmpty(tbDescripcion.Text);
        }


    }
}
