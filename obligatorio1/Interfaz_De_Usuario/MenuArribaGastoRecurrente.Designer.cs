namespace Interfaz_De_Usuario
{
    partial class MenuArribaGastoRecurrente
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
            this.panelGRecurrente = new System.Windows.Forms.Panel();
            this.btnAgregarGastoRecurrente = new System.Windows.Forms.Button();
            this.btnEliminarGRecurrente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelGRecurrente
            // 
            this.panelGRecurrente.Location = new System.Drawing.Point(57, 76);
            this.panelGRecurrente.Name = "panelGRecurrente";
            this.panelGRecurrente.Size = new System.Drawing.Size(792, 434);
            this.panelGRecurrente.TabIndex = 0;
            // 
            // btnAgregarGastoRecurrente
            // 
            this.btnAgregarGastoRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGastoRecurrente.Location = new System.Drawing.Point(57, 29);
            this.btnAgregarGastoRecurrente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregarGastoRecurrente.Name = "btnAgregarGastoRecurrente";
            this.btnAgregarGastoRecurrente.Size = new System.Drawing.Size(305, 42);
            this.btnAgregarGastoRecurrente.TabIndex = 10;
            this.btnAgregarGastoRecurrente.Text = "Agregar Gasto Recurrente";
            this.btnAgregarGastoRecurrente.UseVisualStyleBackColor = true;
            this.btnAgregarGastoRecurrente.Click += new System.EventHandler(this.btnAgregarGastoRecurrente_Click);
            // 
            // btnEliminarGRecurrente
            // 
            this.btnEliminarGRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarGRecurrente.Location = new System.Drawing.Point(402, 29);
            this.btnEliminarGRecurrente.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarGRecurrente.Name = "btnEliminarGRecurrente";
            this.btnEliminarGRecurrente.Size = new System.Drawing.Size(333, 42);
            this.btnEliminarGRecurrente.TabIndex = 16;
            this.btnEliminarGRecurrente.Text = "Eliminar Gasto Recurrente";
            this.btnEliminarGRecurrente.UseVisualStyleBackColor = true;
            this.btnEliminarGRecurrente.Click += new System.EventHandler(this.btnEliminarGRecurrente_Click);
            // 
            // MenuArribaGastoRecurrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminarGRecurrente);
            this.Controls.Add(this.btnAgregarGastoRecurrente);
            this.Controls.Add(this.panelGRecurrente);
            this.Name = "MenuArribaGastoRecurrente";
            this.Size = new System.Drawing.Size(921, 532);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGRecurrente;
        private System.Windows.Forms.Button btnAgregarGastoRecurrente;
        private System.Windows.Forms.Button btnEliminarGRecurrente;
    }
}
