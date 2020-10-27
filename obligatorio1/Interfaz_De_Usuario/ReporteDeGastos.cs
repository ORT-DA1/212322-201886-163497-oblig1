using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ReporteDeGastos : UserControl
    {
        private AdministradorGastosComunes adminGastoComun;
        private AdministradorGastosRecurrentes adminGastoRecurrente;
        private AdministradorReporteGastos adminReporteGastos;

        public ReporteDeGastos(AdministradorGastosComunes AdminGastoComun, AdministradorGastosRecurrentes AdminGastoRecurrente, AdministradorReporteGastos AdminReporteGastos)
        {
            InitializeComponent();
            adminGastoComun = AdminGastoComun;
            adminGastoRecurrente = AdminGastoRecurrente;
            adminReporteGastos = AdminReporteGastos;
            cbMesAnio.DataSource = adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
            
            var listaGastos = adminReporteGastos.UnirListaGastosDelMes(fecha.Year, fecha.Month);
            tablaGastos.Items.Clear();
            foreach (var gasto in listaGastos)
            {
                var row = new string[] { gasto.Fecha.ToString(), gasto.Descripcion.ToString(), gasto.Categoria.ToString(), gasto.Monto.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = listaGastos;
                
                tablaGastos.Items.Add(lvi);

            }

            lbTotal.Text= adminReporteGastos.CalcularMontoDeReporte(listaGastos).ToString();


        }
    }
}
