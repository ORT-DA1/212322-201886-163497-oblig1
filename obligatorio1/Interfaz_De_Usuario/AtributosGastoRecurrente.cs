using System;
using System.Windows.Forms;
using Dominio;
using Excepciones;

namespace Interfaz_De_Usuario
{
    public partial class AtributosGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastosRecurrentes;
        private AdministradorCategorias unAdminCategorias;
        private GastoRecuerrente unGastoRecurrente;
        private AdministradorMonedas unAdminMonedas;
        public AtributosGastoRecurrente(AdministradorGastosRecurrentes miAdminGastosRecurrentes,AdministradorCategorias miAdminCategorias
                ,String descripcion,AdministradorMonedas miAdminMonedas)
        {
            InitializeComponent();
            unAdminGastosRecurrentes = miAdminGastosRecurrentes;
            unAdminCategorias = miAdminCategorias;
            unAdminMonedas = miAdminMonedas;
            unGastoRecurrente = new GastoRecuerrente() { Descripcion = descripcion };
            CargarComboBoxCategorias(descripcion);
            CargarComboBoxMoneda();
        }
        public void CargarComboBoxMoneda()
        {
            cbMoneda.DataSource = unAdminMonedas.RetornarListaMonedas();
        }
        public void CargarComboBoxCategorias(String descripcion)
        {
            
            foreach (Categoria unaCategoria in unAdminCategorias.RetornarListaCategorias())
            {
                cbCategoria.Items.Add(unaCategoria);
            }
            try
            {
               
                Categoria cat = unAdminCategorias.RetornarCategoriaDeDescripcion(descripcion);
                cbCategoria.SelectedItem = cat;

            }
           catch (Exception unaExcepcion)
           when ( unaExcepcion is IndexOutOfRangeException || unaExcepcion is InvalidOperationException || unaExcepcion is ExcepcionElementoNoExistente)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (CampoCategoriaEsVacia())
            {
                MessageBox.Show("La Categoria no puede quedar vacia");
                return;
            }

            try
            {
                unGastoRecurrente.Monto = (double)numMonto.Value;
                //unAdminGastosRecurrentes.AgregarMontoEnPesos(unGastoRecurrente);
                unGastoRecurrente.Fecha = (int)numFecha.Value;
                unGastoRecurrente.Categoria = (Categoria)cbCategoria.SelectedItem;
                unGastoRecurrente.Moneda = (Moneda)cbMoneda.SelectedItem;
                unAdminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecurrente);
                MessageBox.Show("El gasto recurrente ha sido creado con exito");
                numMonto.Value = (decimal)0.00;
                numFecha.Value = 0;
                cbCategoria.SelectedIndex = -1;
                cbMoneda.SelectedIndex = -1;

            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }

        }

        private bool CampoCategoriaEsVacia()
        {
            return cbCategoria.SelectedItem == null;
        }

        

    }
}

