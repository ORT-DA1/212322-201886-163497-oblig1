namespace Interfaz_De_Usuario
{
    partial class ModificarGastoComun
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
            this.cbGastoComun = new System.Windows.Forms.ComboBox();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSeleccionarGasto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificarGasto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGastoComun
            // 
            this.cbGastoComun.FormattingEnabled = true;
            this.cbGastoComun.Location = new System.Drawing.Point(251, 108);
            this.cbGastoComun.Name = "cbGastoComun";
            this.cbGastoComun.Size = new System.Drawing.Size(317, 28);
            this.cbGastoComun.TabIndex = 31;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(602, 103);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 36);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblSeleccionarGasto
            // 
            this.lblSeleccionarGasto.AutoSize = true;
            this.lblSeleccionarGasto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarGasto.Location = new System.Drawing.Point(40, 110);
            this.lblSeleccionarGasto.Name = "lblSeleccionarGasto";
            this.lblSeleccionarGasto.Size = new System.Drawing.Size(193, 26);
            this.lblSeleccionarGasto.TabIndex = 29;
            this.lblSeleccionarGasto.Text = "Seleccionar Gasto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(368, 35);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Modificar Gasto Comun";
            // 
            // btnModificarGasto
            // 
            this.btnModificarGasto.Location = new System.Drawing.Point(602, 420);
            this.btnModificarGasto.Name = "btnModificarGasto";
            this.btnModificarGasto.Size = new System.Drawing.Size(102, 36);
            this.btnModificarGasto.TabIndex = 32;
            this.btnModificarGasto.Text = "Modificar";
            this.btnModificarGasto.UseVisualStyleBackColor = true;
            this.btnModificarGasto.Click += new System.EventHandler(this.btnModificarGasto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 26);
            this.label1.TabIndex = 33;
            this.label1.Text = "Modificar Gasto Seleccionado:";
            // 
            // numMonto
            // 
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Location = new System.Drawing.Point(251, 305);
            this.numMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(317, 26);
            this.numMonto.TabIndex = 40;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(251, 364);
            this.dtFecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(317, 26);
            this.dtFecha.TabIndex = 38;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(251, 425);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(317, 28);
            this.cbCategoria.TabIndex = 37;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(104, 423);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 26);
            this.lblCategoria.TabIndex = 36;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(139, 364);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(71, 26);
            this.lblFecha.TabIndex = 35;
            this.lblFecha.Text = "Fecha";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(139, 302);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(74, 26);
            this.lblMonto.TabIndex = 34;
            this.lblMonto.Text = "Monto";
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(251, 249);
            this.tbDescripcion.MaxLength = 20;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(317, 26);
            this.tbDescripcion.TabIndex = 42;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(94, 249);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(127, 26);
            this.lblDescripcion.TabIndex = 41;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // ModificarGastoComun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.numMonto);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnModificarGasto);
            this.Controls.Add(this.cbGastoComun);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSeleccionarGasto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModificarGastoComun";
            this.Size = new System.Drawing.Size(827, 511);
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGastoComun;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSeleccionarGasto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificarGasto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
