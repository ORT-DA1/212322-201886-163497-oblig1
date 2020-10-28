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
                //para un presupuesto(cbMes), mostrar su lista de CategoriaMonto....
                DateTime fecha = Convert.ToDateTime(cbMesAnio.SelectedItem);
                Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes(fecha.Month, fecha.Year);

                MessageBox.Show("presupuesto elegido: " + presupuesto.Fecha.Month); //solo para ver

                MessageBox.Show("CatMonto " + presupuesto.ListaCategoriaMonto.First().ToString()); //presupuesto nuevo tendria que llenarse automaticamente con todas las cats

                var listaCatMonto = presupuesto.ListaCategoriaMonto;
                listView1.Items.Clear();
                foreach (var catMonto in listaCatMonto)
                {
                    var row = new string[] { catMonto.Categoria.ToString(), catMonto.Monto.ToString() };
                    var lvi = new ListViewItem(row);
                    lvi.Tag = catMonto;
                    //agrego el item a la list view
                    listView1.Items.Add(lvi);

                }
            }
            catch (Exception ex)
            //when (ex is ArgumentOutOfRangeException)
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
                    //agrego el item a la list view
                    listView1.Items.Add(lvi);

                }

            }
            catch(Exception ex)
            when(ex is ArgumentOutOfRangeException)
            {
                MessageBox.Show("Seleccione una categoria para modificar el monto.");
            }
            
              

        }

        
    }

}
