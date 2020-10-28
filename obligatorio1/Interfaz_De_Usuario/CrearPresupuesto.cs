using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
                MessageBox.Show("Presupuesto para Mes: " + presupuesto.Fecha + " ha sido creado con exito");

            }
            catch (Exception unaExcepcion)
            when (unaExcepcion is ExcepcionElementoNoExistente || unaExcepcion is IndexOutOfRangeException || unaExcepcion is ExcepcionElementoRepetido)
            {
                MessageBox.Show(unaExcepcion.Message);
            }
        }

    }
