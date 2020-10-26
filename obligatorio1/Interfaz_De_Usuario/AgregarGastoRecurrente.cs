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
    public partial class AgregarGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;

        private AdministradorCategorias adminCategorias;
        public AdministradorGastosRecurrentes atrGastosRecurrentes { get; set; }
        public AgregarGastoRecurrente(AdministradorGastosRecurrentes miAdminGastosRecurrentes ,AdministradorCategorias miAdminCategorias)
        {
            InitializeComponent();
            adminCategorias = miAdminCategorias;
            adminGastosRecurrentes = miAdminGastosRecurrentes;
            //atrGastosRecurrentes = new AdministradorGastosRecurrentes();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                pGastoRecurrente.Controls.Clear();
                UserControl agregarAtributos = new AtributosGastoRecurrente(adminGastosRecurrentes, adminCategorias, tbDescripcion.Text);
                pGastoRecurrente.Controls.Add(agregarAtributos);
            }
            catch (IndexOutOfRangeException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }
    }
}
