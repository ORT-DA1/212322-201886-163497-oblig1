using System;
using System.Windows.Forms;
using Dominio;


namespace Interfaz_De_Usuario
{
    public partial class AgregarGastoComun : UserControl
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        private AdministradorMonedas adminMonedas;

        public AgregarGastoComun(AdministradorGastosComunes miAdminGastosComunes,AdministradorCategorias miAdministradorCategorias, AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminGastosComunes = miAdminGastosComunes;
            adminCategorias = miAdministradorCategorias;
            adminMonedas = miAdminMonedas;
        }

        private void btnOkDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                pAgregarAtributos.Controls.Clear();
                UserControl agregarAtributos = new AtributosGastoComun(adminGastosComunes,tbDescripcion.Text, adminCategorias,adminMonedas);
                pAgregarAtributos.Controls.Add(agregarAtributos);
            }
            catch(IndexOutOfRangeException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
         
        }
    }
}
