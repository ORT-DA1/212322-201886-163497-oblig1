using System;
using System.Windows.Forms;
using Dominio;

namespace Interfaz_De_Usuario
{
    public partial class AgregarGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes adminGastosRecurrentes;
        private AdministradorCategorias adminCategorias;
        private AdministradorMonedas adminMonedas;
       
        public AgregarGastoRecurrente(AdministradorGastosRecurrentes miAdminGastosRecurrentes ,AdministradorCategorias miAdminCategorias
            ,AdministradorMonedas  miAdminMonedas)
        {
            InitializeComponent();
            adminCategorias = miAdminCategorias;
            adminGastosRecurrentes = miAdminGastosRecurrentes;
            adminMonedas = miAdminMonedas;
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                pGastoRecurrente.Controls.Clear();
                UserControl agregarAtributos = new AtributosGastoRecurrente(adminGastosRecurrentes, adminCategorias, tbDescripcion.Text,adminMonedas);
                pGastoRecurrente.Controls.Add(agregarAtributos);
            }
            catch (IndexOutOfRangeException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }
    }
}
