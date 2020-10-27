namespace Interfaz_De_Usuario
{
    partial class MenuArribaPresupuesto
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
            this.btnCrearPresupuesto = new System.Windows.Forms.Button();
            this.panelPresupuesto = new System.Windows.Forms.Panel();
            this.btnModificarPresupuesto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearPresupuesto
            // 
            this.btnCrearPresupuesto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPresupuesto.Location = new System.Drawing.Point(36, 29);
            this.btnCrearPresupuesto.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            this.btnCrearPresupuesto.Size = new System.Drawing.Size(331, 39);
            this.btnCrearPresupuesto.TabIndex = 11;
            this.btnCrearPresupuesto.Text = "Crear Presupuesto";
            this.btnCrearPresupuesto.UseVisualStyleBackColor = true;
            this.btnCrearPresupuesto.Click += new System.EventHandler(this.btnCrearPresupuesto_Click);
            // 
            // panelPresupuesto
            // 
            this.panelPresupuesto.Location = new System.Drawing.Point(36, 75);
            this.panelPresupuesto.Name = "panelPresupuesto";
            this.panelPresupuesto.Size = new System.Drawing.Size(834, 540);
            this.panelPresupuesto.TabIndex = 12;
            // 
            // btnModificarPresupuesto
            // 
            this.btnModificarPresupuesto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarPresupuesto.Location = new System.Drawing.Point(391, 29);
            this.btnModificarPresupuesto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarPresupuesto.Name = "btnModificarPresupuesto";
            this.btnModificarPresupuesto.Size = new System.Drawing.Size(333, 42);
            this.btnModificarPresupuesto.TabIndex = 13;
            this.btnModificarPresupuesto.Text = "Modificar Presupuesto";
            this.btnModificarPresupuesto.UseVisualStyleBackColor = true;
            this.btnModificarPresupuesto.Click += new System.EventHandler(this.btnModificarPresupuesto_Click);
            // 
            // MenuArribaPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarPresupuesto);
            this.Controls.Add(this.panelPresupuesto);
            this.Controls.Add(this.btnCrearPresupuesto);
            this.Name = "MenuArribaPresupuesto";
            this.Size = new System.Drawing.Size(911, 649);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearPresupuesto;
        private System.Windows.Forms.Panel panelPresupuesto;
        private System.Windows.Forms.Button btnModificarPresupuesto;
    }
}
