namespace Interfaz_De_Usuario
{
    partial class AgregarGastoRecurrente
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
            this.tbDescripcion = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pGastoRecurrente = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDescripcion
            // 
            this.tbDescripcion.Location = new System.Drawing.Point(114, 65);
            this.tbDescripcion.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbDescripcion.MaxLength = 20;
            this.tbDescripcion.Name = "tbDescripcion";
            this.tbDescripcion.Size = new System.Drawing.Size(213, 20);
            this.tbDescripcion.TabIndex = 30;
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescripcion.Location = new System.Drawing.Point(22, 64);
            this.lblDescripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(88, 18);
            this.lblDescripcion.TabIndex = 29;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(20, 19);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(191, 24);
            this.lblTitulo.TabIndex = 28;
            this.lblTitulo.Text = "Gasto Recurrente";
            // 
            // pGastoRecurrente
            // 
            this.pGastoRecurrente.Location = new System.Drawing.Point(4, 107);
            this.pGastoRecurrente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pGastoRecurrente.Name = "pGastoRecurrente";
            this.pGastoRecurrente.Size = new System.Drawing.Size(422, 266);
            this.pGastoRecurrente.TabIndex = 32;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(345, 65);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(81, 21);
            this.btnAgregar.TabIndex = 33;
            this.btnAgregar.Text = "Siguiente";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // AgregarGastoRecurrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pGastoRecurrente);
            this.Controls.Add(this.tbDescripcion);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AgregarGastoRecurrente";
            this.Size = new System.Drawing.Size(528, 400);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tbDescripcion;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pGastoRecurrente;
        private System.Windows.Forms.Button btnAgregar;
    }
}
