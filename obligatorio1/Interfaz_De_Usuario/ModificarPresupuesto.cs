using System;
using System.Windows.Forms;
using Dominio;
using Excepciones;


namespace Interfaz_De_Usuario
{
    public partial class ModificarPresupuesto : UserControl
    {
        private AdministradorPresupuesto adminPresupuestos;
        private AdministradorReportePresupuestos adminReportePresupuestos;
        public ModificarPresupuesto(AdministradorPresupuesto miAdminPresupuesto, AdministradorReportePresupuestos miAdminReportePresupuestos)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuesto;
            adminReportePresupuestos = miAdminReportePresupuestos;
            cargarComboBox();
        }
        public void cargarComboBox()
        {
            foreach (DateTime fecha in adminReportePresupuestos.AgregarYRetornalListaDeMesesDondeHayPresupuestosOrdenada())
            {
                cbMesAnio.Items.Add(fecha.ToString("yyyy/MM"));
            }
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
                Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes(fecha.Month, fecha.Year);
                var listaCatMonto = adminPresupuestos.RetornarCatMonto(presupuesto);
                listView1.Items.Clear();
                foreach (var catMonto in listaCatMonto)
                {
                    var row = new string[] { catMonto.Categoria.ToString(), catMonto.Monto.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = catMonto;
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnModificarMonto_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
                Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes(fecha.Month, fecha.Year);
                var categoriaMontoSeleccionado = (CategoriaMonto)listView1.SelectedItems[0].Tag;
                int nuevoMonto = (int)nudMonto.Value;
                adminPresupuestos.ModificarMontoACategoria(presupuesto, categoriaMontoSeleccionado.Categoria, nuevoMonto);
                var listaCatMonto = presupuesto.ListaCategoriaMonto;
                listView1.Items.Clear();
                foreach (var catMonto in listaCatMonto)
                {
                    var row = new string[] { catMonto.Categoria.ToString(), catMonto.Monto.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = catMonto;
                    listView1.Items.Add(lvi);
                }
            }
            catch (Exception ex)
            when (ex is ArgumentOutOfRangeException || ex is ExcepcionElementoNoExistente)
            {
                MessageBox.Show("Seleccione una categoria para modificar el monto.");
            }
        }
    }
}
