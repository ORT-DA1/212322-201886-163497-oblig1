using System;
using System.Windows.Forms;
using Dominio;
using Excepciones;

namespace Interfaz_De_Usuario
{
    public partial class CrearPresupuesto : UserControl
    {
        private AdministradorPresupuesto adminPresupuestos;
        private Presupuesto presupuesto;

        public CrearPresupuesto(AdministradorPresupuesto miAdminPresupuestos)
        {
            InitializeComponent();
            adminPresupuestos = miAdminPresupuestos;
            presupuesto = new Presupuesto();
        }
        private void btnCrearPresupuesto2_Click(object sender, EventArgs e)
        {
            try
            {
                presupuesto.Fecha = dtFecha.Value;
                adminPresupuestos.AgregarPresupuesto(presupuesto);
                MessageBox.Show("Presupuesto creado con éxito, ir a Modificar Presupuesto para asignarle un monto");

            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException || unaExcepcion is ExcepcionElementoRepetido)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

    }
}
