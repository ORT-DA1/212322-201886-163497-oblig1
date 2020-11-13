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
    public partial class AgregarMoneda : UserControl
    {
        private AdministradorMonedas adminMonedas;
        public AgregarMoneda(AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            adminMonedas = miAdminMonedas;
        }
    }
}
