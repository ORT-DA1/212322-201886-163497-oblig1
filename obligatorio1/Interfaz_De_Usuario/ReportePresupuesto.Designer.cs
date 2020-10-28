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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblReportePresupuesto = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.hdrCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrReal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrDiferencia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cbMesAnio = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.chartPresupuesto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartPresupuesto2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresupuesto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresupuesto2)).BeginInit();
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
            this.listView1.Location = new System.Drawing.Point(26, 71);
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
            this.cbMesAnio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbMesAnio.Name = "cbMesAnio";
            this.cbMesAnio.Size = new System.Drawing.Size(168, 21);
            this.cbMesAnio.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(218, 48);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(106, 19);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // chartPresupuesto
            // 
            chartArea1.Name = "ChartArea1";
            this.chartPresupuesto.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartPresupuesto.Legends.Add(legend1);
            this.chartPresupuesto.Location = new System.Drawing.Point(545, 46);
            this.chartPresupuesto.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPresupuesto.Name = "chartPresupuesto";
            series1.ChartArea = "ChartArea1";
            series1.LabelBorderColor = System.Drawing.Color.Transparent;
            series1.Legend = "Legend1";
            series1.LegendText = "Planificado";
            series1.Name = "Planificado";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Real";
            this.chartPresupuesto.Series.Add(series1);
            this.chartPresupuesto.Series.Add(series2);
            this.chartPresupuesto.Size = new System.Drawing.Size(353, 230);
            this.chartPresupuesto.TabIndex = 14;
            this.chartPresupuesto.Text = "chartPresupuesto";
            title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Presupuesto";
            title1.Text = "Presupuesto";
            title1.TextOrientation = System.Windows.Forms.DataVisualization.Charting.TextOrientation.Horizontal;
            this.chartPresupuesto.Titles.Add(title1);
            // 
            // chartPresupuesto2
            // 
            chartArea2.Name = "ChartArea1";
            this.chartPresupuesto2.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.chartPresupuesto2.Legends.Add(legend2);
            this.chartPresupuesto2.Location = new System.Drawing.Point(545, 292);
            this.chartPresupuesto2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chartPresupuesto2.Name = "chartPresupuesto2";
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.IsValueShownAsLabel = true;
            series3.Label = "#PERCENT{P0}";
            series3.LabelBorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series3.Legend = "Legend1";
            series3.Name = "s1";
            this.chartPresupuesto2.Series.Add(series3);
            this.chartPresupuesto2.Size = new System.Drawing.Size(353, 222);
            this.chartPresupuesto2.TabIndex = 15;
            this.chartPresupuesto2.Text = "chartPresupuesto2";
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Presupuesto";
            this.chartPresupuesto2.Titles.Add(title2);
            // 
            // ReportePresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.chartPresupuesto2);
            this.Controls.Add(this.chartPresupuesto);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbMesAnio);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.lblReportePresupuesto);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "ReportePresupuesto";
            this.Size = new System.Drawing.Size(1067, 681);
            ((System.ComponentModel.ISupportInitialize)(this.chartPresupuesto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartPresupuesto2)).EndInit();
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
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPresupuesto;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartPresupuesto2;
    }
}
