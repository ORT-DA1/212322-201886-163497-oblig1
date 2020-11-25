namespace Interfaz_De_Usuario
{
    partial class ModificarGastoRecurrente
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cbGastoRecurrente = new System.Windows.Forms.ComboBox();
            this.lblSeleccionarGasto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.numFecha = new System.Windows.Forms.NumericUpDown();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMoneda = new System.Windows.Forms.ComboBox();
            this.btnModificarDescripcion = new System.Windows.Forms.Button();
            this.btnModificarMonto = new System.Windows.Forms.Button();
            this.btnModificarDia = new System.Windows.Forms.Button();
            this.btnModificarCategoria = new System.Windows.Forms.Button();
            this.btnModificarMoneda = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGastoRecurrente
            // 
            this.cbGastoRecurrente.FormattingEnabled = true;
            this.cbGastoRecurrente.Location = new System.Drawing.Point(35, 81);
            this.cbGastoRecurrente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbGastoRecurrente.Name = "cbGastoRecurrente";
            this.cbGastoRecurrente.Size = new System.Drawing.Size(650, 24);
            this.cbGastoRecurrente.TabIndex = 35;

            // 
            // lblSeleccionarGasto
            // 
            this.lblSeleccionarGasto.AutoSize = true;
            this.lblSeleccionarGasto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarGasto.Location = new System.Drawing.Point(32, 61);
            this.lblSeleccionarGasto.Name = "lblSeleccionarGasto";
            this.lblSeleccionarGasto.Size = new System.Drawing.Size(131, 18);
            this.lblSeleccionarGasto.TabIndex = 33;
            this.lblSeleccionarGasto.Text = "Gasto a modificar";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(31, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(296, 24);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Modificar Gasto Recurrente";
            // 
            // numFecha
            // 
            this.numFecha.Location = new System.Drawing.Point(299, 269);
            this.numFecha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numFecha.Name = "numFecha";
            this.numFecha.Size = new System.Drawing.Size(276, 22);
            this.numFecha.TabIndex = 41;
            // 
            // numMonto
            // 
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Location = new System.Drawing.Point(299, 219);
            this.numMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(276, 22);
            this.numMonto.TabIndex = 40;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(298, 313);
            this.cbCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(277, 24);
            this.cbCategoria.TabIndex = 39;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(197, 316);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(75, 18);
            this.lblCategoria.TabIndex = 38;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(184, 267);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(89, 18);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Dia del mes";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(213, 219);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(57, 18);
            this.lblMonto.TabIndex = 36;
            this.lblMonto.Text = "Monto ";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(299, 172);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbDescripcion.MaxLength = 20;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(277, 22);
            this.tbDescripcion.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(188, 170);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(88, 18);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(208, 362);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 50;
            this.label2.Text = "Moneda";
            // 
            // cbMoneda
            // 
            this.cbMoneda.FormattingEnabled = true;
            this.cbMoneda.Location = new System.Drawing.Point(298, 359);
            this.cbMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMoneda.Name = "cbMoneda";
            this.cbMoneda.Size = new System.Drawing.Size(277, 24);
            this.cbMoneda.TabIndex = 51;
            // 
            // btnModificarDescripcion
            // 
            this.btnModificarDescripcion.Location = new System.Drawing.Point(594, 172);
            this.btnModificarDescripcion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarDescripcion.Name = "btnModificarDescripcion";
            this.btnModificarDescripcion.Size = new System.Drawing.Size(91, 29);
            this.btnModificarDescripcion.TabIndex = 53;
            this.btnModificarDescripcion.Text = "Modificar";
            this.btnModificarDescripcion.UseVisualStyleBackColor = true;
            this.btnModificarDescripcion.Click += new System.EventHandler(this.btnModificarDescripcion_Click);
            // 
            // btnModificarMonto
            // 
            this.btnModificarMonto.Location = new System.Drawing.Point(594, 215);
            this.btnModificarMonto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMonto.Name = "btnModificarMonto";
            this.btnModificarMonto.Size = new System.Drawing.Size(91, 29);
            this.btnModificarMonto.TabIndex = 54;
            this.btnModificarMonto.Text = "Modificar";
            this.btnModificarMonto.UseVisualStyleBackColor = true;
            this.btnModificarMonto.Click += new System.EventHandler(this.btnModificarMonto_Click);
            // 
            // btnModificarDia
            // 
            this.btnModificarDia.Location = new System.Drawing.Point(594, 265);
            this.btnModificarDia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarDia.Name = "btnModificarDia";
            this.btnModificarDia.Size = new System.Drawing.Size(91, 29);
            this.btnModificarDia.TabIndex = 55;
            this.btnModificarDia.Text = "Modificar";
            this.btnModificarDia.UseVisualStyleBackColor = true;
            this.btnModificarDia.Click += new System.EventHandler(this.btnModificarDia_Click);
            // 
            // btnModificarCategoria
            // 
            this.btnModificarCategoria.Location = new System.Drawing.Point(594, 313);
            this.btnModificarCategoria.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarCategoria.Name = "btnModificarCategoria";
            this.btnModificarCategoria.Size = new System.Drawing.Size(91, 29);
            this.btnModificarCategoria.TabIndex = 56;
            this.btnModificarCategoria.Text = "Modificar";
            this.btnModificarCategoria.UseVisualStyleBackColor = true;
            this.btnModificarCategoria.Click += new System.EventHandler(this.btnModificarCategoria_Click);
            // 
            // btnModificarMoneda
            // 
            this.btnModificarMoneda.Location = new System.Drawing.Point(594, 357);
            this.btnModificarMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarMoneda.Name = "btnModificarMoneda";
            this.btnModificarMoneda.Size = new System.Drawing.Size(91, 29);
            this.btnModificarMoneda.TabIndex = 57;
            this.btnModificarMoneda.Text = "Modificar";
            this.btnModificarMoneda.UseVisualStyleBackColor = true;
            this.btnModificarMoneda.Click += new System.EventHandler(this.btnModificarMoneda_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(593, 109);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(91, 29);
            this.btnEliminar.TabIndex = 58;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // ModificarGastoRecurrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificarMoneda);
            this.Controls.Add(this.btnModificarCategoria);
            this.Controls.Add(this.btnModificarDia);
            this.Controls.Add(this.btnModificarMonto);
            this.Controls.Add(this.btnModificarDescripcion);
            this.Controls.Add(this.cbMoneda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.numFecha);
            this.Controls.Add(this.numMonto);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cbGastoRecurrente);
            this.Controls.Add(this.lblSeleccionarGasto);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModificarGastoRecurrente";
            this.Size = new System.Drawing.Size(708, 418);
            ((System.ComponentModel.ISupportInitialize)(this.numFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGastoRecurrente;
        private System.Windows.Forms.Label lblSeleccionarGasto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown numFecha;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMoneda;
        private System.Windows.Forms.Button btnModificarDescripcion;
        private System.Windows.Forms.Button btnModificarMonto;
        private System.Windows.Forms.Button btnModificarDia;
        private System.Windows.Forms.Button btnModificarCategoria;
        private System.Windows.Forms.Button btnModificarMoneda;
        private System.Windows.Forms.Button btnEliminar;
    }
}
