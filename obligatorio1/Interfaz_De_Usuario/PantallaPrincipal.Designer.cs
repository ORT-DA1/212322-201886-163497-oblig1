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
            this.btnAgregarCategoria = new System.Windows.Forms.Button();
            this.btnCrearPresupuesto = new System.Windows.Forms.Button();
            this.btnReporteGastos = new System.Windows.Forms.Button();
            this.btnGastoComun = new System.Windows.Forms.Button();
            this.btGastoRecurrente = new System.Windows.Forms.Button();
            this.btnReportePres = new System.Windows.Forms.Button();
            this.logo = new System.Windows.Forms.Panel();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.btnMoneda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCategoria.Location = new System.Drawing.Point(64, 136);
            this.btnAgregarCategoria.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(250, 34);
            this.btnAgregarCategoria.TabIndex = 6;
            this.btnAgregarCategoria.Text = "Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // btnCrearPresupuesto
            // 
            this.btnCrearPresupuesto.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearPresupuesto.Location = new System.Drawing.Point(64, 363);
            this.btnCrearPresupuesto.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            this.btnCrearPresupuesto.Size = new System.Drawing.Size(249, 31);
            this.btnCrearPresupuesto.TabIndex = 10;
            this.btnCrearPresupuesto.Text = "Presupuesto";
            this.btnCrearPresupuesto.UseVisualStyleBackColor = true;
            this.btnCrearPresupuesto.Click += new System.EventHandler(this.btnCrearPresupuesto_Click);
            // 
            // btnReporteGastos
            // 
            this.btnReporteGastos.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporteGastos.Location = new System.Drawing.Point(65, 423);
            this.btnReporteGastos.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReporteGastos.Name = "btnReporteGastos";
            this.btnReporteGastos.Size = new System.Drawing.Size(250, 34);
            this.btnReporteGastos.TabIndex = 16;
            this.btnReporteGastos.Text = "Reporte de Gastos";
            this.btnReporteGastos.UseVisualStyleBackColor = true;
            this.btnReporteGastos.Click += new System.EventHandler(this.btnReporteGastos_Click);
            // 
            // btnGastoComun
            // 
            this.btnGastoComun.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGastoComun.Location = new System.Drawing.Point(66, 244);
            this.btnGastoComun.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnGastoComun.Name = "btnGastoComun";
            this.btnGastoComun.Size = new System.Drawing.Size(250, 34);
            this.btnGastoComun.TabIndex = 17;
            this.btnGastoComun.Text = "Gasto Comun";
            this.btnGastoComun.UseVisualStyleBackColor = true;
            this.btnGastoComun.Click += new System.EventHandler(this.btnGastoComun_Click);
            // 
            // btGastoRecurrente
            // 
            this.btGastoRecurrente.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGastoRecurrente.Location = new System.Drawing.Point(66, 304);
            this.btGastoRecurrente.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btGastoRecurrente.Name = "btGastoRecurrente";
            this.btGastoRecurrente.Size = new System.Drawing.Size(248, 32);
            this.btGastoRecurrente.TabIndex = 19;
            this.btGastoRecurrente.Text = "Gasto Recurrente";
            this.btGastoRecurrente.UseVisualStyleBackColor = true;
            this.btGastoRecurrente.Click += new System.EventHandler(this.btGastoRecurrente_Click);
            // 
            // btnReportePres
            // 
            this.btnReportePres.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportePres.Location = new System.Drawing.Point(65, 490);
            this.btnReportePres.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnReportePres.Name = "btnReportePres";
            this.btnReportePres.Size = new System.Drawing.Size(250, 34);
            this.btnReportePres.TabIndex = 20;
            this.btnReportePres.Text = "Reporte de Presupuesto";
            this.btnReportePres.UseVisualStyleBackColor = true;
            this.btnReportePres.Click += new System.EventHandler(this.btnReportePres_Click);
            // 
            // logo
            // 
            this.logo.BackgroundImage = global::Interfaz_De_Usuario.Properties.Resources.Logo_misfinanzas_02;
            this.logo.Location = new System.Drawing.Point(65, 14);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(224, 98);
            this.logo.TabIndex = 21;
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = global::Interfaz_De_Usuario.Properties.Resources.Logo_misfinanzas_04;
            this.panelPrincipal.Location = new System.Drawing.Point(352, 90);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(896, 762);
            this.panelPrincipal.TabIndex = 0;
            // 
            // btnMoneda
            // 
            this.btnMoneda.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoneda.Location = new System.Drawing.Point(66, 186);
            this.btnMoneda.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnMoneda.Name = "btnMoneda";
            this.btnMoneda.Size = new System.Drawing.Size(250, 34);
            this.btnMoneda.TabIndex = 22;
            this.btnMoneda.Text = "Moneda";
            this.btnMoneda.UseVisualStyleBackColor = true;
            this.btnMoneda.Click += new System.EventHandler(this.btnMoneda_Click);
            // 
            // PantallaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1283, 690);
            this.Controls.Add(this.btnMoneda);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.btnReportePres);
            this.Controls.Add(this.btGastoRecurrente);
            this.Controls.Add(this.btnGastoComun);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.btnReporteGastos);
            this.Controls.Add(this.btnCrearPresupuesto);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "PantallaPrincipal";
            this.Text = "Mis Finanzas Personales";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAgregarCategoria;
        private System.Windows.Forms.Button btnCrearPresupuesto;
        private System.Windows.Forms.Button btnReporteGastos;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Button btnGastoComun;
        private System.Windows.Forms.Button btGastoRecurrente;
        private System.Windows.Forms.Button btnReportePres;
        private System.Windows.Forms.Panel logo;
        private System.Windows.Forms.Button btnMoneda;
    }
}

