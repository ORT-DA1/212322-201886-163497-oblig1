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
    public partial class ModificarGastoComun : UserControl
    {
        private AdministradorGastosComunes unAdminGastoComun;
        private AdministradorCategorias unAdminCategorias;

        public ModificarGastoComun(AdministradorGastosComunes miAdminGastoComun, AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            unAdminGastoComun = miAdminGastoComun;
            unAdminCategorias = miAdminCategorias;
            CargarComboBox();
        }
        public void CargarComboBox()
        {
            cbGastoComun.DataSource = unAdminGastoComun.RetornarListaGastosComunes();
            cbCategoria.DataSource = unAdminCategorias.RetornarListaCategorias();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
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

        private void btnModificarGasto_Click(object sender, EventArgs e)
        {
            if (HayCamposVacios())
            {
                MessageBox.Show("Categoria y Descripción no pueden quedar vacias");
                return;
            }

            GastoComun gastoAmodificar = (GastoComun)cbGastoComun.SelectedItem;
            gastoAmodificar.Descripcion = tbDescripcion.Text;
            gastoAmodificar.Monto = (double)numMonto.Value;
            gastoAmodificar.Fecha = dtFecha.Value;
            gastoAmodificar.Categoria = (Categoria)cbCategoria.SelectedItem;
            MessageBox.Show("El gasto ha modificado con exito ");

        }

        private bool HayCamposVacios()
        {
            return cbGastoComun.SelectedItem == null || string.IsNullOrEmpty(tbDescripcion.Text);
        }
    }
}
