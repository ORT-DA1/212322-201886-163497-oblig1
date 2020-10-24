using Dominio;
using Excepciones;
using System;
using System.Windows.Forms;

namespace Interfaz_De_Usuario
{

    public partial class AtributosGastoComun : UserControl
    {
        private AdministradorGastosComunes unAdminGastosComun;
        private AdministradorCategorias unAdminCategorias;
        private GastoComun gastoC;
        public AtributosGastoComun(AdministradorGastosComunes miAdminGastoComun, String descripcion, AdministradorCategorias miAdministradorCategorias)
        {
            InitializeComponent();
            unAdminGastosComun = miAdminGastoComun;
            unAdminCategorias = miAdministradorCategorias;
            CargarComboBox(descripcion);
        }

        private void CargarComboBox(String descripcion)
        {

            foreach (Categoria unaCategoria in unAdminCategorias.RetornarListaCategorias())
            {
                cbCategoria.Items.Add(unaCategoria);
            }
            try
            {
                Categoria cat = unAdminCategorias.RetornarCategoriaDeDescripcion(descripcion);
                gastoC = new GastoComun() { Descripcion = descripcion };

            } catch (Exception unaExcepcion)
             when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            gastoC.Monto = (double)numMonto.Value;
            gastoC.Fecha = dtFecha.Value;
            gastoC.Categoria = unAdminCategorias.RetornarCategoriaSegunString(cbCategoria.Text);

        }
    }
}
