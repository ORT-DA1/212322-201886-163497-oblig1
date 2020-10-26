using Dominio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class PantallaPrincipal : Form
    { 

        public AdministradorCategorias AdminCategorias { get; set; }
        public AdministradorGastosComunes AdminGastoComun { get; set; }
        public AdministradorGastosRecurrentes AdminGastoRecurrente { get; set; }
        public AdministradorPresupuesto AdminPresupuesto { get; set; }
        public Repositorio Repositorio { get; set; }
        public PantallaPrincipal()
        {
            InitializeComponent();
            Repositorio = new Repositorio();
            AdminPresupuesto = new AdministradorPresupuesto(Repositorio);
            AdminCategorias = new AdministradorCategorias(Repositorio);
            AdminGastoComun = new AdministradorGastosComunes(Repositorio);
            AdminGastoRecurrente = new AdministradorGastosRecurrentes(Repositorio);
            
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl modificarCategoria = new ModificarCategoria(AdminCategorias);
            panelPrincipal.Controls.Add(modificarCategoria);
        }

        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarCategoria = new AgregarCategoria(AdminCategorias);
            panelPrincipal.Controls.Add(agregarCategoria);
        }

        private void btnAgregarGasto_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarGastoComun = new AgregarGastoComun(AdminGastoComun,AdminCategorias);
            panelPrincipal.Controls.Add(agregarGastoComun);
        }

        private void btnAgregarGastoRecurrente_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl agregarGastoRecurrente = new AgregarGastoRecurrente(AdminGastoRecurrente, AdminCategorias);
            panelPrincipal.Controls.Add(agregarGastoRecurrente);

        }

        private void btnCrearPresupuesto_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl crearPresupuesto = new CrearPresupuesto(AdminPresupuesto, AdminCategorias);
            panelPrincipal.Controls.Add(crearPresupuesto);

        }

        private void btnModificarPresupuesto_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl crearPresupuesto = new ModificarPresupuesto(AdminPresupuesto);
            panelPrincipal.Controls.Add(crearPresupuesto);
        }

        private void btnReportePresupuesto_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl reportePresupuesto = new ReportePresupuesto(AdminPresupuesto);
            panelPrincipal.Controls.Add(reportePresupuesto);
        }
    }
}
