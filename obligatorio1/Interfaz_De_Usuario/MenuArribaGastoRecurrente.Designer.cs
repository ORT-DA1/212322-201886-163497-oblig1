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
            this.btnListadoGastos = new System.Windows.Forms.Button();
            this.btnModificarGastoRecurrente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // panelGRecurrente
            // 
            this.panelGRecurrente.Location = new System.Drawing.Point(38, 49);
            this.panelGRecurrente.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelGRecurrente.Name = "panelGRecurrente";
            this.panelGRecurrente.Size = new System.Drawing.Size(528, 320);
            this.panelGRecurrente.TabIndex = 0;
            // 
            // btnAgregarGastoRecurrente
            // 
            this.btnAgregarGastoRecurrente.BackColor = System.Drawing.Color.Wheat;
            this.btnAgregarGastoRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGastoRecurrente.Location = new System.Drawing.Point(38, 19);
            this.btnAgregarGastoRecurrente.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarGastoRecurrente.Name = "btnAgregarGastoRecurrente";
            this.btnAgregarGastoRecurrente.Size = new System.Drawing.Size(213, 27);
            this.btnAgregarGastoRecurrente.TabIndex = 10;
            this.btnAgregarGastoRecurrente.Text = "Agregar Gasto Recurrente";
            this.btnAgregarGastoRecurrente.UseVisualStyleBackColor = false;
            this.btnAgregarGastoRecurrente.Click += new System.EventHandler(this.btnAgregarGastoRecurrente_Click);
            // 
            // btnListadoGastos
            // 
            this.btnListadoGastos.BackColor = System.Drawing.Color.Wheat;
            this.btnListadoGastos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoGastos.Location = new System.Drawing.Point(507, 19);
            this.btnListadoGastos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnListadoGastos.Name = "btnListadoGastos";
            this.btnListadoGastos.Size = new System.Drawing.Size(250, 27);
            this.btnListadoGastos.TabIndex = 21;
            this.btnListadoGastos.Text = "Listado de Gasto Recurrente";
            this.btnListadoGastos.UseVisualStyleBackColor = false;
            this.btnListadoGastos.Click += new System.EventHandler(this.btnListadoGastos_Click);
            // 
            // btnModificarGastoRecurrente
            // 
            this.btnModificarGastoRecurrente.BackColor = System.Drawing.Color.Wheat;
            this.btnModificarGastoRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarGastoRecurrente.Location = new System.Drawing.Point(263, 19);
            this.btnModificarGastoRecurrente.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnModificarGastoRecurrente.Name = "btnModificarGastoRecurrente";
            this.btnModificarGastoRecurrente.Size = new System.Drawing.Size(235, 27);
            this.btnModificarGastoRecurrente.TabIndex = 17;
            this.btnModificarGastoRecurrente.Text = "Modificar Gasto Recurrente";
            this.btnModificarGastoRecurrente.UseVisualStyleBackColor = false;
            this.btnModificarGastoRecurrente.Click += new System.EventHandler(this.btnModificarGastoRecurrente_Click);
            // 
            // MenuArribaGastoRecurrente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarGastoRecurrente);
            this.Controls.Add(this.btnListadoGastos);
            this.Controls.Add(this.btnAgregarGastoRecurrente);
            this.Controls.Add(this.panelGRecurrente);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "MenuArribaGastoRecurrente";
            this.Size = new System.Drawing.Size(1200, 700);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGRecurrente;
        private System.Windows.Forms.Button btnAgregarGastoRecurrente;
        private System.Windows.Forms.Button btnListadoGastos;
        private System.Windows.Forms.Button btnModificarGastoRecurrente;
    }
}
