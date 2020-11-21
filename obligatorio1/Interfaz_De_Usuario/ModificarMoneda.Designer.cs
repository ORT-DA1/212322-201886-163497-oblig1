namespace Interfaz_De_Usuario
{
    partial class ModificarMoneda
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnElegir = new System.Windows.Forms.Button();
            this.cbMonedas = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.panelNuevo = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btnElegir
            // 
            this.btnElegir.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnElegir.Location = new System.Drawing.Point(220, 103);
            this.btnElegir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnElegir.Name = "btnElegir";
            this.btnElegir.Size = new System.Drawing.Size(145, 28);
            this.btnElegir.TabIndex = 34;
            this.btnElegir.Text = "Elegir";
            this.btnElegir.UseVisualStyleBackColor = true;
            this.btnElegir.Click += new System.EventHandler(this.btnElegir_Click);
            // 
            // cbMonedas
            // 
            this.cbMonedas.FormattingEnabled = true;
            this.cbMonedas.Location = new System.Drawing.Point(135, 75);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Size = new System.Drawing.Size(231, 24);
            this.cbMonedas.TabIndex = 32;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(195, 24);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Modificar Moneda";
            // 
            // panelNuevo
            // 
            this.panelNuevo.Location = new System.Drawing.Point(20, 136);
            this.panelNuevo.Name = "panelNuevo";
            this.panelNuevo.Size = new System.Drawing.Size(624, 361);
            this.panelNuevo.TabIndex = 35;
            // 
            // ModificarMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelNuevo);
            this.Controls.Add(this.btnElegir);
            this.Controls.Add(this.cbMonedas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModificarMoneda";
            this.Size = new System.Drawing.Size(791, 585);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnElegir;
        private System.Windows.Forms.ComboBox cbMonedas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel panelNuevo;
    }
}
