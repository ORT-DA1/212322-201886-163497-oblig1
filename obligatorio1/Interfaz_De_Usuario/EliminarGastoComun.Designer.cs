namespace Interfaz_De_Usuario
{
    partial class EliminarGastoComun
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
            this.SuspendLayout();
            // 
            // cbGastoComun
            // 
            this.cbGastoComun.FormattingEnabled = true;
            this.cbGastoComun.Location = new System.Drawing.Point(251, 108);
            this.cbGastoComun.Name = "cbGastoComun";
            this.cbGastoComun.Size = new System.Drawing.Size(300, 28);
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
            this.lblTitulo.Size = new System.Drawing.Size(356, 35);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Eliminar Gasto Comun";
            // 
            // EliminarGastoComun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbGastoComun);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lblSeleccionarGasto);
            this.Controls.Add(this.lblTitulo);
            this.Name = "EliminarGastoComun";
            this.Size = new System.Drawing.Size(775, 208);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbGastoComun;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Label lblSeleccionarGasto;
        private System.Windows.Forms.Label lblTitulo;
    }
}
