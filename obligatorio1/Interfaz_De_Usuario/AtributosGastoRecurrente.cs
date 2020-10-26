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
    public partial class AtributosGastoRecurrente : UserControl
    {
        private AdministradorGastosRecurrentes unAdminGastosRecurrentes;
        private AdministradorCategorias unAdminCategorias;
        private GastoRecuerrente unGastoRecurrente;
        public AtributosGastoRecurrente(AdministradorGastosRecurrentes miAdminGastosRecurrentes,AdministradorCategorias miAdminCategorias,String descripcion)
        {
            InitializeComponent();
            unAdminGastosRecurrentes = miAdminGastosRecurrentes;
            unAdminCategorias = miAdminCategorias;
            unGastoRecurrente = new GastoRecuerrente() { Descripcion = descripcion };
            CargarComboBox(descripcion);
        }
        public void CargarComboBox(String descripcion)
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
            if (cbCategoria.SelectedItem == null)
            {
                MessageBox.Show("La Categoria no puede quedar vacia");
                return;
            }

            try
            {
                unGastoRecurrente.Monto = (double)numMonto.Value;
                unGastoRecurrente.Fecha = (int)numFecha.Value;
                unGastoRecurrente.Categoria = (Categoria)cbCategoria.SelectedItem;
                unAdminGastosRecurrentes.AgregarGastoRecurrente(unGastoRecurrente);
                MessageBox.Show("El gasto recurrente ha sido creado con exito ");

                

            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
            
        }

       
    }
}

