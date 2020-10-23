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
    public partial class AgregarGastoComun : UserControl
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        public AdministradorGastosComunes atrGastosComun { get; set; }
        public AgregarGastoComun(AdministradorGastosComunes miAdminGastosComunes,AdministradorCategorias miAdministradorCategorias)
        {
            InitializeComponent();
            adminGastosComunes = miAdminGastosComunes;
            atrGastosComun = new AdministradorGastosComunes();
            adminCategorias = miAdministradorCategorias;

        }

        private void btnOkDescripcion_Click(object sender, EventArgs e)
        {
            Categoria cat = adminCategorias.RetornarCategoriaDeDescripcion(tbDescripcion.Text);   
            try
            {
                GastoComun gastoC = new GastoComun { Descripcion = tbDescripcion.Text };
                pAgregarAtributos.Controls.Clear();
                UserControl agregarAtributos = new AtributosGastoComun(atrGastosComun);
                pAgregarAtributos.Controls.Add(agregarAtributos);
            }
            catch ()
            {

            }
           
        }
    }
}
