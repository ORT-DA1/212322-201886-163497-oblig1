namespace Interfaz_De_Usuario
{
    partial class PantallaPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnAgregarGasto = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnAgregarGastoRecurrente = new System.Windows.Forms.Button();
            this.btnCrearPresupuesto = new System.Windows.Forms.Button();
            this.btnModificarPresupuesto = new System.Windows.Forms.Button();

            this.btnEliminarGComun = new System.Windows.Forms.Button();
            this.btnEliminarGRecurrente = new System.Windows.Forms.Button();

            this.btnReportePresupuesto = new System.Windows.Forms.Button();

            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(394, 29);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(663, 581);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(12, 45);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(333, 46);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = " Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGasto.Location = new System.Drawing.Point(12, 145);
            this.btnAgregarGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(333, 42);
            this.btnAgregarGasto.TabIndex = 7;
            this.btnAgregarGasto.Text = " Agregar Gasto Comun";
            this.btnAgregarGasto.UseVisualStyleBackColor = true;
            this.btnAgregarGasto.Click += new System.EventHandler(this.btnAgregarGasto_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(10, 95);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(333, 46);
            this.button1.TabIndex = 8;
            this.button1.Text = "Modificar Categoria";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAgregarGastoRecurrente
            // 
            this.btnAgregarGastoRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGastoRecurrente.Location = new System.Drawing.Point(12, 237);
            this.btnAgregarGastoRecurrente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarGastoRecurrente.Name = "btnAgregarGastoRecurrente";
            this.btnAgregarGastoRecurrente.Size = new System.Drawing.Size(333, 50);
            this.btnAgregarGastoRecurrente.TabIndex = 9;
            this.btnAgregarGastoRecurrente.Text = "Agregar Gasto Recurrente";
            this.btnAgregarGastoRecurrente.UseVisualStyleBackColor = true;
            this.btnAgregarGastoRecurrente.Click += new System.EventHandler(this.btnAgregarGastoRecurrente_Click);
            // 
            // btnCrearPresupuesto
            // 
            this.btnCrearPresupuesto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPresupuesto.Location = new System.Drawing.Point(12, 339);
            this.btnCrearPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            this.btnCrearPresupuesto.Size = new System.Drawing.Size(331, 39);
            this.btnCrearPresupuesto.TabIndex = 10;
            this.btnCrearPresupuesto.Text = "Crear Presupuesto";
            this.btnCrearPresupuesto.UseVisualStyleBackColor = true;
            this.btnCrearPresupuesto.Click += new System.EventHandler(this.btnCrearPresupuesto_Click);
            // 
            // btnModificarPresupuesto
            // 
            this.btnModificarPresupuesto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPresupuesto.Location = new System.Drawing.Point(12, 384);
            this.btnModificarPresupuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPresupuesto.Name = "btnModificarPresupuesto";
            this.btnModificarPresupuesto.Size = new System.Drawing.Size(333, 42);
            this.btnModificarPresupuesto.TabIndex = 11;
            this.btnModificarPresupuesto.Text = "Modificar Presupuesto";
            this.btnModificarPresupuesto.UseVisualStyleBackColor = true;
            this.btnModificarPresupuesto.Click += new System.EventHandler(this.btnModificarPresupuesto_Click);
            // 

            // btnEliminarGComun
            // 
            this.btnEliminarGComun.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGComun.Location = new System.Drawing.Point(12, 191);
            this.btnEliminarGComun.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarGComun.Name = "btnEliminarGComun";
            this.btnEliminarGComun.Size = new System.Drawing.Size(333, 42);
            this.btnEliminarGComun.TabIndex = 14;
            this.btnEliminarGComun.Text = "Eliminar Gasto Comun";
            this.btnEliminarGComun.UseVisualStyleBackColor = true;
            this.btnEliminarGComun.Click += new System.EventHandler(this.btnEliminarGComun_Click);
            // 
            // btnEliminarGRecurrente
            // 
            this.btnEliminarGRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGRecurrente.Location = new System.Drawing.Point(12, 291);
            this.btnEliminarGRecurrente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarGRecurrente.Name = "btnEliminarGRecurrente";
            this.btnEliminarGRecurrente.Size = new System.Drawing.Size(333, 42);
            this.btnEliminarGRecurrente.TabIndex = 15;
            this.btnEliminarGRecurrente.Text = "Eliminar Gasto Recurrente";
            this.btnEliminarGRecurrente.UseVisualStyleBackColor = true;
            this.btnEliminarGRecurrente.Click += new System.EventHandler(this.btnEliminarGRecurrente_Click);

            // btnReportePresupuesto
            // 
            this.btnReportePresupuesto.Location = new System.Drawing.Point(13, 377);
            this.btnReportePresupuesto.Name = "btnReportePresupuesto";
            this.btnReportePresupuesto.Size = new System.Drawing.Size(294, 32);
            this.btnReportePresupuesto.TabIndex = 12;
            this.btnReportePresupuesto.Text = "Reporte Presupuesto";
            this.btnReportePresupuesto.UseVisualStyleBackColor = true;
            this.btnReportePresupuesto.Click += new System.EventHandler(this.btnReportePresupuesto_Click);

            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;

            this.ClientSize = new System.Drawing.Size(1127, 702);
            this.Controls.Add(this.btnEliminarGRecurrente);
            this.Controls.Add(this.btnEliminarGComun);

            this.ClientSize = new System.Drawing.Size(1002, 562);
            this.Controls.Add(this.btnReportePresupuesto);

            this.Controls.Add(this.btnModificarPresupuesto);
            this.Controls.Add(this.btnCrearPresupuesto);
            this.Controls.Add(this.btnAgregarGastoRecurrente);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAgregarGasto);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.panelPrincipal);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarGasto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnAgregarGastoRecurrente;
        private System.Windows.Forms.Button btnCrearPresupuesto;
        private System.Windows.Forms.Button btnModificarPresupuesto;
        private System.Windows.Forms.Button btnEliminarGComun;
        private System.Windows.Forms.Button btnEliminarGRecurrente;
        private System.Windows.Forms.Button btnReportePresupuesto;

    }
}

