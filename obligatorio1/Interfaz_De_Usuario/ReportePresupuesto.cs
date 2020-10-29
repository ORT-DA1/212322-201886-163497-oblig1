using System;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class ReportePresupuesto : UserControl
    {
        private AdministradorPresupuesto adminPresupuestos;
        private AdministradorReportePresupuestos adminReportePresupuestos;
        private AdministradorReporteGastos adminReporteGastos;

        public ReportePresupuesto(AdministradorPresupuesto miAdminPresupuesto, AdministradorReportePresupuestos miAdminReportePresupuestos, AdministradorReporteGastos miAdminReporteGastos)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuesto;
            adminReportePresupuestos = miAdminReportePresupuestos;
            adminReporteGastos = miAdminReporteGastos;

            cbMesAnio.DataSource = adminReportePresupuestos.AgregarYRetornalListaDeMesesDondeHayPresupuestosOrdenada();
            //cargarGraficas();
        }


        private void btnConsultar_Click(object sender, EventArgs e)
        {
            

            try
            {
                DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
                Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes(fecha.Month, fecha.Year);
                var listaCatMonto = presupuesto.ListaCategoriaMonto;
                listView1.Items.Clear();
                foreach (var catMonto in listaCatMonto)
                {
                    double gastoTotalDeCatEnMes = adminReporteGastos.CalcularGastoTotalDeCategoriaEnMes(fecha.Year, fecha.Month, catMonto.Categoria);
                    double diferenciaTotalPlanificado = catMonto.Monto - gastoTotalDeCatEnMes;
                    String diferenciaTotalPlanificadoString = diferenciaTotalPlanificado.ToString();
                  
                    var row = new string[] { catMonto.Categoria.ToString(), catMonto.Monto.ToString(), gastoTotalDeCatEnMes.ToString(), diferenciaTotalPlanificadoString };
                    var lvi = new ListViewItem(row);
                   
                    ///* COLOR ROJO:
                   
                    if (diferenciaTotalPlanificado < 0.00)
                    {
                        lvi.SubItems[3].ForeColor = Color.Red;
                        lvi.SubItems[3].BackColor = Color.Red;
                    }
                    //*/
                    listView1.Items.Add(lvi);

                       this.chartPresupuesto.Series["Planificado"].Points.AddXY(catMonto.Categoria.ToString(), catMonto.Monto);
                       this.chartPresupuesto.Series["Real"].Points.AddXY(catMonto.Categoria.ToString(), gastoTotalDeCatEnMes.ToString());

                       this. chartPresupuesto2.Series["s2"].Points.AddXY(catMonto.Categoria.ToString(), gastoTotalDeCatEnMes);
                      
                }
            }
            catch (Exception ex)

            {
                MessageBox.Show(ex.Message);
            }

        }

        
    }
}

