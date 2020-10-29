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
            //chartPresupuesto2.Titles.Add("Gasto real por categoría");

            Title title = new Title();
            title.Font = new Font("Arial", 14);
            title.Text = "Gasto real por categoría";
            chartPresupuesto2.Titles.Add(title);

            cbMesAnio.DataSource = adminReportePresupuestos.AgregarYRetornalListaDeMesesDondeHayPresupuestosOrdenada();
           
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

