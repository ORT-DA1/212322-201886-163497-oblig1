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
            Presupuesto presupuesto = adminPresupuestos.RetornarPresupuestoSegunMes((String)cbMes.SelectedItem, (int)nudAnio.Value);
            MessageBox.Show("presupuesto elegido: " + presupuesto.ToString()); //solo para ver
            MessageBox.Show("CatMonto " + presupuesto.ListaCategoriaMonto.First().ToString()); //presupuesto nuevo tendria que llenarse automaticamente con todas las cats

        }
    }
}
