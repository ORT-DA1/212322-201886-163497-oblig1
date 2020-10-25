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
        public ModificarPresupuesto(AdministradorPresupuesto miAdminPresupuesto)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuesto;
            cbMes.SelectedItem = "Enero";
        }

        private void btnVerPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes((String)cbMes.SelectedItem, (int)nudAnio.Value);
                MessageBox.Show("presupuesto elegido: " + presupuesto.ToString()); //solo para ver
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
            }catch (Exception ex)
            //when (ex is ArgumentOutOfRangeException)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void btnModificarMonto_Click(object sender, EventArgs e)
        {
            try
            {
                Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes((String)cbMes.SelectedItem, (int)nudAnio.Value);
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
