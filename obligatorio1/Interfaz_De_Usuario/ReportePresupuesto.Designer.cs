namespace Interfaz_De_Usuario
{
    partial class ReportePresupuesto
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
            this.lblReportePresupuesto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.listView1 = new System.Windows.Forms.ListView();
            this.hdrCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrReal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDiferencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnVerReporte = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReportePresupuesto
            // 
            this.lblReportePresupuesto.AutoSize = true;
            this.lblReportePresupuesto.Location = new System.Drawing.Point(32, 19);
            this.lblReportePresupuesto.Name = "lblReportePresupuesto";
            this.lblReportePresupuesto.Size = new System.Drawing.Size(162, 17);
            this.lblReportePresupuesto.TabIndex = 0;
            this.lblReportePresupuesto.Text = "Reporte de presupuesto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ano";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbMes.Location = new System.Drawing.Point(35, 81);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(120, 24);
            this.cbMes.TabIndex = 4;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(185, 81);
            this.nudAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(136, 22);
            this.nudAnio.TabIndex = 5;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrCategoria,
            this.hdrMonto,
            this.hdrReal,
            this.hdrDiferencia});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(35, 121);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(480, 261);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // hdrCategoria
            // 
            this.hdrCategoria.Text = "Categoria";
            this.hdrCategoria.Width = 117;
            // 
            // hdrMonto
            // 
            this.hdrMonto.Text = "Planificado";
            this.hdrMonto.Width = 122;
            // 
            // hdrReal
            // 
            this.hdrReal.Text = "Real";
            this.hdrReal.Width = 117;
            // 
            // hdrDiferencia
            // 
            this.hdrDiferencia.Text = "Diferencia";
            this.hdrDiferencia.Width = 150;
            // 
            // btnVerReporte
            // 
            this.btnVerReporte.Location = new System.Drawing.Point(353, 81);
            this.btnVerReporte.Name = "btnVerReporte";
            this.btnVerReporte.Size = new System.Drawing.Size(142, 23);
            this.btnVerReporte.TabIndex = 8;
            this.btnVerReporte.Text = "Ver reporte";
            this.btnVerReporte.UseVisualStyleBackColor = true;
            this.btnVerReporte.Click += new System.EventHandler(this.btnVerReporte_Click);
            // 
            // ReportePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVerReporte);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblReportePresupuesto);
            this.Name = "ReportePresupuesto";
            this.Size = new System.Drawing.Size(725, 443);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportePresupuesto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader hdrCategoria;
        private System.Windows.Forms.ColumnHeader hdrMonto;
        private System.Windows.Forms.ColumnHeader hdrReal;
        private System.Windows.Forms.ColumnHeader hdrDiferencia;
        private System.Windows.Forms.Button btnVerReporte;
    }
}
