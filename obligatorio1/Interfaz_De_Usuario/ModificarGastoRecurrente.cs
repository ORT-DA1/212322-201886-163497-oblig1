using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ModificarGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastoRecurrente;
        private AdministradorCategorias unAdminCategorias;
        private AdministradorMonedas unAdminMonedas;
        public ModificarGastoRecurrente(AdministradorGastosRecurrentes miAdminGastoRecurrente, AdministradorCategorias miAdminCategorias, AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            unAdminGastoRecurrente = miAdminGastoRecurrente;
            unAdminCategorias = miAdminCategorias;
            unAdminMonedas = miAdminMonedas;
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            cbGastoRecurrente.DataSource = unAdminGastoRecurrente.RetornarListaGastosRecurrentes();
            cbCategoria.DataSource = unAdminCategorias.RetornarListaCategorias();
            cbMoneda.DataSource = unAdminMonedas.RetornarListaMonedas();
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

        private bool HayCamposVacios()
        {
            return cbGastoRecurrente.SelectedItem == null || string.IsNullOrEmpty(tbDescripcion.Text);
        }
        /*
        private void btnModificarGasto_Click_1(object sender, EventArgs e)
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
                gastoAmodificar.Moneda = (Moneda)cbMoneda.SelectedItem;
                MessageBox.Show("El gasto ha modificado con exito ");
            }

            catch (IndexOutOfRangeException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }*/

        private void btnModificarDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoElegido = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                unAdminGastoRecurrente.ModificarDescripcion(gastoElegido, tbDescripcion.Text);
                MessageBox.Show("Descripcion " + tbDescripcion.Text + " modificada con éxito");
                tbDescripcion.Clear();
                cbGastoRecurrente.DataSource = null;
                CargarComboBox();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarMonto_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoElegido = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                unAdminGastoRecurrente.ModificarMonto(gastoElegido, (int)numMonto.Value);
                MessageBox.Show("Monto modificado con éxito");
                numMonto.Value = 0; 
                cbGastoRecurrente.DataSource = null;
                CargarComboBox();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarDia_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoElegido = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                unAdminGastoRecurrente.ModificarMonto(gastoElegido, (int)numFecha.Value);
                MessageBox.Show("Fecha modificada con éxito");
                numFecha.Value = 0;
                cbGastoRecurrente.DataSource = null;
                CargarComboBox();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoElegido = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                Categoria categoriaElegida = (Categoria)cbCategoria.SelectedItem;
                unAdminGastoRecurrente.ModificarCategoria(gastoElegido, categoriaElegida);
                MessageBox.Show("Categoria modificada con éxito");
                
                cbGastoRecurrente.DataSource = null;
                CargarComboBox();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnModificarMoneda_Click(object sender, EventArgs e)
        {
            try
            {
                GastoRecuerrente gastoElegido = (GastoRecuerrente)cbGastoRecurrente.SelectedItem;
                Moneda monedaElegida = (Moneda)cbMoneda.SelectedItem;
                unAdminGastoRecurrente.ModificarMoneda(gastoElegido, monedaElegida);
                MessageBox.Show("Moneda modificada con éxito");

                cbGastoRecurrente.DataSource = null;
                CargarComboBox();
            }
            catch (Exception unaExcepcion)
            //when (unaExcepcion is ExcepcionElementoRepetido || unaExcepcion is ExcepcionPalabraLarga)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }
    }
}
