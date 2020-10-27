namespace Interfaz_De_Usuario
{
    partial class ListadoGastosComunes
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
            this.lstGastosComunes = new System.Windows.Forms.ListBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstGastosComunes
            // 
            this.lstGastosComunes.FormattingEnabled = true;
            this.lstGastosComunes.ItemHeight = 20;
            this.lstGastosComunes.Location = new System.Drawing.Point(33, 110);
            this.lstGastosComunes.Name = "lstGastosComunes";
            this.lstGastosComunes.Size = new System.Drawing.Size(636, 284);
            this.lstGastosComunes.TabIndex = 0;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(27, 29);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(280, 35);
            this.lblTitulo.TabIndex = 29;
            this.lblTitulo.Text = "Listado de gastos";
            // 
            // ListadoGastosComunes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.lstGastosComunes);
            this.Name = "ListadoGastosComunes";
            this.Size = new System.Drawing.Size(761, 497);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstGastosComunes;
        private System.Windows.Forms.Label lblTitulo;
    }
}
