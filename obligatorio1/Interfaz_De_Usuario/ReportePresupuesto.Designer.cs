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
            this.listView1 = new System.Windows.Forms.ListView();
            this.hdrCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrReal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDiferencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbMesAnio = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblReportePresupuesto
            // 
            this.lblReportePresupuesto.AutoSize = true;
            this.lblReportePresupuesto.Location = new System.Drawing.Point(24, 15);
            this.lblReportePresupuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblReportePresupuesto.Name = "lblReportePresupuesto";
            this.lblReportePresupuesto.Size = new System.Drawing.Size(121, 13);
            this.lblReportePresupuesto.TabIndex = 0;
            this.lblReportePresupuesto.Text = "Reporte de presupuesto";
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
            this.listView1.Location = new System.Drawing.Point(26, 98);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(492, 222);
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
            // cbMesAnio
            // 
            this.cbMesAnio.FormattingEnabled = true;
            this.cbMesAnio.Location = new System.Drawing.Point(26, 46);
            this.cbMesAnio.Margin = new System.Windows.Forms.Padding(2);
            this.cbMesAnio.Name = "cbMesAnio";
            this.cbMesAnio.Size = new System.Drawing.Size(168, 21);
            this.cbMesAnio.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(218, 48);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(106, 19);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ReportePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbMesAnio);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblReportePresupuesto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportePresupuesto";
            this.Size = new System.Drawing.Size(544, 360);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblReportePresupuesto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader hdrCategoria;
        private System.Windows.Forms.ColumnHeader hdrMonto;
        private System.Windows.Forms.ColumnHeader hdrReal;
        private System.Windows.Forms.ColumnHeader hdrDiferencia;
        private System.Windows.Forms.ComboBox cbMesAnio;
        private System.Windows.Forms.Button btnConsultar;
    }
}
