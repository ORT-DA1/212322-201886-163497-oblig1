using Dominio;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class PantallaPrincipal : Form
    { 

        public AdministradorCategorias AdminCategorias { get; set; }
        public AdministradorGastosComunes AdminGastoComun { get; set; }
        public AdministradorGastosRecurrentes AdminGastoRecurrente { get; set; }
        public AdministradorPresupuesto AdminPresupuesto { get; set; }
        public IRepositorio Repositorio { get; set; }
        public AdministradorReporteGastos AdminReporteGastos { get; set; }
        public AdministradorReportePresupuestos AdminReportePresupuestos { get; set; }
        public AdministradorMonedas AdminMonedas { get; set; }

        public PantallaPrincipal()
        {
            InitializeComponent();
            
            //Datos para repo en memoria
            /*
            List<PalabraClave> palabras = new List<PalabraClave>() { new PalabraClave() { Palabra = "Cine" } };
            Categoria categoria = new Categoria() { Nombre = "Entretenimiento", PalabrasClave = palabras };
            AdminCategorias.AgregarCategoria(categoria);
            Moneda moneda = new Moneda() { Cotizacion = 50, Nombre = "UYU", Simbolo = "$" };
            AdminMonedas.AgregarMoneda(moneda);
            GastoComun gasto = new GastoComun() { Categoria = categoria, Moneda = moneda };
            GastoRecuerrente gasto2 = new GastoRecuerrente() { Categoria = categoria };
            AdminGastoComun.AgregarGastoComun(gasto);
            AdminGastoRecurrente.AgregarGastoRecurrente(gasto2);
            */

            //Repositorio = new RepositorioMemoria();
            Repositorio = new RepositorioBD();
            AdminPresupuesto = new AdministradorPresupuesto(Repositorio);
            AdminCategorias = new AdministradorCategorias(Repositorio);
            AdminGastoComun = new AdministradorGastosComunes(Repositorio);
            AdminGastoRecurrente = new AdministradorGastosRecurrentes(Repositorio);
            AdminReporteGastos = new AdministradorReporteGastos(Repositorio);
            AdminReportePresupuestos = new AdministradorReportePresupuestos(Repositorio);
            AdminMonedas = new AdministradorMonedas(Repositorio);



        }


        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            
            panelPrincipal.Controls.Clear();
            UserControl menuArriba = new MenuArribaCategoria(AdminCategorias);
            panelPrincipal.Controls.Add(menuArriba);

        }

        private void btnMoneda_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl menuArriba = new MenuArribaMoneda(AdminMonedas);
            panelPrincipal.Controls.Add(menuArriba);
        }

        private void btnGastoComun_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl menuArriba = new MenuArribaGasto(AdminGastoComun, AdminCategorias,AdminMonedas);
            panelPrincipal.Controls.Add(menuArriba);
        }

        private void btGastoRecurrente_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl gastoRecurrente = new MenuArribaGastoRecurrente(AdminGastoRecurrente, AdminCategorias,AdminMonedas);
            panelPrincipal.Controls.Add(gastoRecurrente);
        }

        private void btnCrearPresupuesto_Click(object sender, EventArgs e)
        {
           
            panelPrincipal.Controls.Clear();
            UserControl presupuesto = new MenuArribaPresupuesto(AdminPresupuesto, AdminCategorias, AdminReportePresupuestos);
            panelPrincipal.Controls.Add(presupuesto);

        }

        private void btnReporteGastos_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl reporteGastos = new ReporteDeGastos(AdminReporteGastos);
            panelPrincipal.Controls.Add(reporteGastos);
        }


        private void btnReportePres_Click(object sender, EventArgs e)
        {
            panelPrincipal.Controls.Clear();
            UserControl reportePresupuesto = new ReportePresupuesto(AdminPresupuesto, AdminReportePresupuestos, AdminReporteGastos);
            panelPrincipal.Controls.Add(reportePresupuesto);
        }

        
    }
}
