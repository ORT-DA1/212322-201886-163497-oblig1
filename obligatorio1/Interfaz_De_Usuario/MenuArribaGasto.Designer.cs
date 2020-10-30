namespace Interfaz_De_Usuario
{
    partial class MenuArribaGasto
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
            this.btnAgregarGastoC = new System.Windows.Forms.Button();
            this.panelGastoComun = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnListadoGastos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarGastoC
            // 
            this.btnAgregarGastoC.BackColor = System.Drawing.Color.Beige;
            this.btnAgregarGastoC.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarGastoC.Location = new System.Drawing.Point(82, 22);
            this.btnAgregarGastoC.Name = "btnAgregarGastoC";
            this.btnAgregarGastoC.Size = new System.Drawing.Size(273, 42);
            this.btnAgregarGastoC.TabIndex = 0;
            this.btnAgregarGastoC.Text = "Agregar Gasto Comun";
            this.btnAgregarGastoC.UseVisualStyleBackColor = false;
            this.btnAgregarGastoC.Click += new System.EventHandler(this.btnAgregarGastoC_Click);
            // 
            // panelGastoComun
            // 
            this.panelGastoComun.Location = new System.Drawing.Point(82, 86);
            this.panelGastoComun.Name = "panelGastoComun";
            this.panelGastoComun.Size = new System.Drawing.Size(834, 488);
            this.panelGastoComun.TabIndex = 1;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Beige;
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(372, 22);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(268, 42);
            this.btnEliminar.TabIndex = 18;
            this.btnEliminar.Text = "Modificar Gasto";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnListadoGastos
            // 
            this.btnListadoGastos.BackColor = System.Drawing.Color.Beige;
            this.btnListadoGastos.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListadoGastos.Location = new System.Drawing.Point(658, 22);
            this.btnListadoGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListadoGastos.Name = "btnListadoGastos";
            this.btnListadoGastos.Size = new System.Drawing.Size(256, 42);
            this.btnListadoGastos.TabIndex = 19;
            this.btnListadoGastos.Text = "Ver Listado de Gastos";
            this.btnListadoGastos.UseVisualStyleBackColor = false;
            this.btnListadoGastos.Click += new System.EventHandler(this.btnListadoGastos_Click);
            // 
            // MenuArribaGasto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnListadoGastos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.panelGastoComun);
            this.Controls.Add(this.btnAgregarGastoC);
            this.Name = "MenuArribaGasto";
            this.Size = new System.Drawing.Size(1800, 1077);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarGastoC;
        private System.Windows.Forms.Panel panelGastoComun;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnListadoGastos;
    }
}
