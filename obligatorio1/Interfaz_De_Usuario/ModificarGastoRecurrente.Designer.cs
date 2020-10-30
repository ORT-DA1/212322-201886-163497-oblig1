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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.lblSeleccionarGasto = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.numFecha = new System.Windows.Forms.NumericUpDown();
            this.numMonto = new System.Windows.Forms.NumericUpDown();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMonto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnModificarGasto = new System.Windows.Forms.Button();
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numFecha)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // cbGastoRecurrente
            // 
            this.cbGastoRecurrente.FormattingEnabled = true;
            this.cbGastoRecurrente.Location = new System.Drawing.Point(253, 101);
            this.cbGastoRecurrente.Name = "cbGastoRecurrente";
            this.cbGastoRecurrente.Size = new System.Drawing.Size(311, 28);
            this.cbGastoRecurrente.TabIndex = 35;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(586, 101);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(102, 30);
            this.btnEliminar.TabIndex = 34;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // lblSeleccionarGasto
            // 
            this.lblSeleccionarGasto.AutoSize = true;
            this.lblSeleccionarGasto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeleccionarGasto.Location = new System.Drawing.Point(36, 99);
            this.lblSeleccionarGasto.Name = "lblSeleccionarGasto";
            this.lblSeleccionarGasto.Size = new System.Drawing.Size(193, 26);
            this.lblSeleccionarGasto.TabIndex = 33;
            this.lblSeleccionarGasto.Text = "Seleccionar Gasto";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(35, 30);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(429, 35);
            this.lblTitulo.TabIndex = 32;
            this.lblTitulo.Text = "Modificar Gasto Recurrente";
            // 
            // numFecha
            // 
            this.numFecha.Location = new System.Drawing.Point(253, 348);
            this.numFecha.Name = "numFecha";
            this.numFecha.Size = new System.Drawing.Size(311, 26);
            this.numFecha.TabIndex = 41;
            // 
            // numMonto
            // 
            this.numMonto.DecimalPlaces = 2;
            this.numMonto.Location = new System.Drawing.Point(253, 285);
            this.numMonto.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numMonto.Name = "numMonto";
            this.numMonto.Size = new System.Drawing.Size(311, 26);
            this.numMonto.TabIndex = 40;
            // 
            // cbCategoria
            // 
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(253, 406);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(311, 28);
            this.cbCategoria.TabIndex = 39;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(104, 406);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 26);
            this.lblCategoria.TabIndex = 38;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.Location = new System.Drawing.Point(89, 345);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(130, 26);
            this.lblFecha.TabIndex = 37;
            this.lblFecha.Text = "Dia del mes";
            // 
            // lblMonto
            // 
            this.lblMonto.AutoSize = true;
            this.lblMonto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonto.Location = new System.Drawing.Point(44, 284);
            this.lblMonto.Name = "lblMonto";
            this.lblMonto.Size = new System.Drawing.Size(176, 26);
            this.lblMonto.TabIndex = 36;
            this.lblMonto.Text = "Monto Tentativo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 26);
            this.label1.TabIndex = 43;
            this.label1.Text = "Modificar Gasto Seleccionado:";
            // 
            // btnModificarGasto
            // 
            this.btnModificarGasto.Location = new System.Drawing.Point(586, 401);
            this.btnModificarGasto.Name = "btnModificarGasto";
            this.btnModificarGasto.Size = new System.Drawing.Size(102, 36);
            this.btnModificarGasto.TabIndex = 44;
            this.btnModificarGasto.Text = "Modificar";
            this.btnModificarGasto.UseVisualStyleBackColor = true;
            this.btnModificarGasto.Click += new System.EventHandler(this.btnModificarGasto_Click);
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(253, 226);
            this.tbDescripcion.MaxLength = 20;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(311, 26);
            this.tbDescripcion.TabIndex = 46;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(93, 224);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(127, 26);
            this.lblDescripcion.TabIndex = 45;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // ModificarGastoRecurrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.btnModificarGasto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numFecha);
            this.Controls.Add(this.numMonto);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblMonto);
            this.Controls.Add(this.cbGastoRecurrente);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSeleccionarGasto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModificarGastoRecurrente";
            this.Size = new System.Drawing.Size(759, 467);
            ((System.ComponentModel.ISupportInitialize)(this.numFecha)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGastoRecurrente;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSeleccionarGasto;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.NumericUpDown numFecha;
        private System.Windows.Forms.NumericUpDown numMonto;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMonto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnModificarGasto;
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
    }
}
