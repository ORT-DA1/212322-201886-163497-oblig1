using System;
using System.Collections.Generic;
using Dominio;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{
    public partial class ListadoGastosComunes : UserControl
    {

        private AdministradorGastosComunes unAdminGastoComun;

        public ListadoGastosComunes(AdministradorGastosComunes miAdminGastoComun)
        {
            InitializeComponent();
            unAdminGastoComun = miAdminGastoComun;
            CargarListaGastosComunes();
        }

        public void CargarListaGastosComunes()
        {
            lstGastosComunes.DataSource = unAdminGastoComun.RetornarListaGastosComunes();
        }


    }
}
