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
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Location = new System.Drawing.Point(351, 31);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(663, 581);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(47, 31);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(234, 46);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = " Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnAgregarGasto
            // 
            this.btnAgregarGasto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGasto.Location = new System.Drawing.Point(47, 178);
            this.btnAgregarGasto.Name = "btnAgregarGasto";
            this.btnAgregarGasto.Size = new System.Drawing.Size(234, 42);
            this.btnAgregarGasto.TabIndex = 7;
            this.btnAgregarGasto.Text = " Agregar Gasto";
            this.btnAgregarGasto.UseVisualStyleBackColor = true;
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1127, 703);
            this.Controls.Add(this.btnAgregarGasto);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.panelPrincipal);
            this.Name = "PantallaPrincipal";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnAgregarGasto;
    }
}

