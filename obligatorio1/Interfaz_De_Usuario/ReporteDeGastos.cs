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
using System.IO;

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
            CargarComboFormatosDeExportar();

        }

        private void CargarComboBoxFechas()
        {
            foreach (DateTime fecha in adminReporteGastos.CrearYRetornalListaDeMesesDondeHayGastoOrdenada())
            {
                cbMesAnio.Items.Add(fecha.ToString("yyyy/MM"));

            }

        }

        private void CargarComboFormatosDeExportar()
        {
            cbTipoDeArchivo.Items.AddRange(new object[] { "txt", "csv", "xml" });
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
            
            var listaGastos = adminReporteGastos.UnirListaGastosDelMes(fecha.Year, fecha.Month);
            tablaGastos.Items.Clear();
            foreach (var gasto in listaGastos)
            {
                var row = new string[] { gasto.Fecha.ToShortDateString(), gasto.Descripcion.ToString(), gasto.Categoria.ToString(),gasto.Monto.ToString(), gasto.Moneda.ToString()};
                var lvi = new ListViewItem(row);
                lvi.Tag = listaGastos;
                
                tablaGastos.Items.Add(lvi);

            }

            lbTotal.Text= adminReporteGastos.CalcularMontoDeReporte(listaGastos).ToString();
        }

      
        private void btnExportar_Click(object sender, EventArgs e)
        {
            if(cbTipoDeArchivo.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar el tipo de archivo que quiere exportar");
            }
            else if (cbMesAnio.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un mes para exportar el reporte");
            }
            else
            {
                DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
                List<GastoComun> listaAExportar = adminReporteGastos.UnirListaGastosDelMes(fecha.Year, fecha.Month);

                String tipoArchivo = cbTipoDeArchivo.Text;

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.FileName = "*." + tipoArchivo;
                sfd.DefaultExt = tipoArchivo;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    ExportarReporteGasto exportar = ExportarReporteGastoFabrica.CrearExportacion(tipoArchivo);
                    Stream fileStream = sfd.OpenFile();
                    exportar.Exportar(listaAExportar, fileStream);
                    MessageBox.Show("Gastos exportados con exito");

                }

            }
            

        }


    }
}
