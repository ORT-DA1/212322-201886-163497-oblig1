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
    public partial class ReporteDeGastos : UserControl
    {

         private AdministradorReporteGastos adminReporteGastos;

        public ReporteDeGastos(AdministradorReporteGastos AdminReporteGastos)
        {
            InitializeComponent();
            adminReporteGastos = AdminReporteGastos;
            CargarComboBoxFechas();

        }

        private void CargarComboBoxFechas()
        {
            foreach (DateTime fecha in adminReporteGastos.AgregarYRetornalListaDeMesesDondeHayGastoOrdenada())
            {
                cbMesAnio.Items.Add(fecha.ToString("yyyy/MM"));

            }

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
            
            var listaGastos = adminReporteGastos.UnirListaGastosDelMes(fecha.Year, fecha.Month);
            tablaGastos.Items.Clear();
            foreach (var gasto in listaGastos)
            {
                var row = new string[] { gasto.Fecha.ToShortDateString(), gasto.Descripcion.ToString(), gasto.Categoria.ToString(), gasto.Monto.ToString() };
                var lvi = new ListViewItem(row);
                lvi.Tag = listaGastos;
                
                tablaGastos.Items.Add(lvi);

            }

            lbTotal.Text= adminReporteGastos.CalcularMontoDeReporte(listaGastos).ToString();


        }
    }
}
