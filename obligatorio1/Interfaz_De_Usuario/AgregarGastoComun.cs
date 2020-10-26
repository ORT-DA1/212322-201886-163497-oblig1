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
    public partial class AgregarGastoComun : UserControl
    {
        private AdministradorGastosComunes adminGastosComunes;
        private AdministradorCategorias adminCategorias;
        public AdministradorGastosComunes atrGastosComun { get; set; }
        public Repositorio miRepositorio;
        public AgregarGastoComun(AdministradorGastosComunes miAdminGastosComunes,AdministradorCategorias miAdministradorCategorias)
        {
            InitializeComponent();
            adminGastosComunes = miAdminGastosComunes;
            adminCategorias = miAdministradorCategorias;
        }

        private void btnOkDescripcion_Click(object sender, EventArgs e)
        {
            try
            {
                pAgregarAtributos.Controls.Clear();
                UserControl agregarAtributos = new AtributosGastoComun(adminGastosComunes, tbDescripcion.Text, adminCategorias);
                pAgregarAtributos.Controls.Add(agregarAtributos);
            }catch(IndexOutOfRangeException unaExcepcion)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
         
        }
    }
}
