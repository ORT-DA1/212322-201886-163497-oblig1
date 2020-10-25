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
    public partial class CrearPresupuesto : UserControl
    {
        private AdministradorCategorias adminCategorias;
        private AdministradorPresupuesto adminPresupuestos;
        
        public CrearPresupuesto(AdministradorPresupuesto miAdminPresupuestos, AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuestos;
            cbMes.SelectedItem = "Enero";
            
        }

        private void btnCrearPresupuesto_Click(object sender, EventArgs e)
        {
            try
            {
                Presupuesto presupuesto = new Presupuesto() { Mes = (String)cbMes.SelectedItem, Anio = (int)nudAnio.Value };
                adminPresupuestos.AgregarPresupuesto(presupuesto);
                MessageBox.Show("Presupuesto para Mes: " + presupuesto.Mes + " Anio:" + nudAnio.Value + " ha sido creado con exito");

            }
            catch (Exception unaExepcion)
            //when (unaExepcion is ExcepcionElementoRepetido )
            {
                MessageBox.Show(unaExepcion.Message);

            }
        }
    }
}
