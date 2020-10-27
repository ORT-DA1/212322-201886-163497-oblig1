namespace Interfaz_De_Usuario
{
    partial class ListadoGastosRecurrentes
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lstGastosRecurrentes = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(40, 41);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(466, 35);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Listado de gastos recurrentes";
            // 
            // lstGastosRecurrentes
            // 
            this.lstGastosRecurrentes.FormattingEnabled = true;
            this.lstGastosRecurrentes.ItemHeight = 20;
            this.lstGastosRecurrentes.Location = new System.Drawing.Point(46, 122);
            this.lstGastosRecurrentes.Name = "lstGastosRecurrentes";
            this.lstGastosRecurrentes.Size = new System.Drawing.Size(636, 284);
            this.lstGastosRecurrentes.TabIndex = 30;
            // 
            // ListadoGastosRecurrentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstGastosRecurrentes);
            this.Name = "ListadoGastosRecurrentes";
            this.Size = new System.Drawing.Size(808, 583);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lstGastosRecurrentes;
    }
}
