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
       //public GastoComun gastoC { get; set; }
        private GastoComun gastoC;
        public AtributosGastoComun(AdministradorGastosComunes miAdminGastoComun, String descripcion, AdministradorCategorias miAdministradorCategorias)
        {
            InitializeComponent();
            unAdminGastosComun = miAdminGastoComun;
            unAdminCategorias = miAdministradorCategorias;
            gastoC = new GastoComun() {Descripcion = descripcion};
            CargarComboBox(descripcion,gastoC);
            
        }

        private void CargarComboBox(String descripcion,GastoComun gastoC)
        {

            foreach (Categoria unaCategoria in unAdminCategorias.RetornarListaCategorias())
            {
                cbCategoria.Items.Add(unaCategoria);
            }
            try
            {

                Categoria cat = unAdminCategorias.RetornarCategoriaDeDescripcion(descripcion);
                //gastoC.Descripcion = descripcion ;

            } catch (Exception unaExcepcion)
             when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
           
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                gastoC.Monto = (double)numMonto.Value;
                gastoC.Fecha = dtFecha.Value;
                gastoC.Categoria = unAdminCategorias.RetornarCategoriaSegunString(cbCategoria.Text);
                unAdminGastosComun.AgregarGastoComun(gastoC);
                MessageBox.Show("El gasto ha sido creada con exito " + gastoC.ToString());
            }
            catch(Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
           

        }
    }
}
