namespace Interfaz_De_Usuario
{
    partial class ReporteDeGastos
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.cbMesAnio = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblMes = new System.Windows.Forms.Label();
            this.s = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tablaGastos = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbTotal = new System.Windows.Forms.Label();
            this.btnExportar = new System.Windows.Forms.Button();
            this.cbTipoDeArchivo = new System.Windows.Forms.ComboBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.ReporteGasto = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGasto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(15, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(203, 24);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Reporte de Gastos";
            // 
            // cbMesAnio
            // 
            this.cbMesAnio.FormattingEnabled = true;
            this.cbMesAnio.Location = new System.Drawing.Point(87, 76);
            this.cbMesAnio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMesAnio.Name = "cbMesAnio";
            this.cbMesAnio.Size = new System.Drawing.Size(223, 24);
            this.cbMesAnio.TabIndex = 11;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(335, 69);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(124, 33);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(24, 74);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(35, 18);
            this.lblMes.TabIndex = 13;
            this.lblMes.Text = "Mes";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(406, 385);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(121, 16);
            this.s.TabIndex = 15;
            this.s.Text = "Total del mes en $:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(527, 373);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 16);
            this.label2.TabIndex = 16;
            // 
            // tablaGastos
            // 
            this.tablaGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.tablaGastos.GridLines = true;
            this.tablaGastos.HideSelection = false;
            this.tablaGastos.Location = new System.Drawing.Point(3, 143);
            this.tablaGastos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tablaGastos.Name = "tablaGastos";
            this.tablaGastos.Size = new System.Drawing.Size(603, 210);
            this.tablaGastos.TabIndex = 17;
            this.tablaGastos.UseCompatibleStateImageBehavior = false;
            this.tablaGastos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Fecha";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Descripcion";
            this.columnHeader2.Width = 136;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Categoria";
            this.columnHeader3.Width = 154;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Monto";
            this.columnHeader4.Width = 99;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Moneda";
            this.columnHeader5.Width = 91;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotal.Location = new System.Drawing.Point(546, 385);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(45, 16);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "monto";
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(284, 385);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(76, 31);
            this.btnExportar.TabIndex = 19;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            this.btnExportar.Click += new System.EventHandler(this.btnExportar_Click);
            // 
            // cbTipoDeArchivo
            // 
            this.cbTipoDeArchivo.FormattingEnabled = true;
            this.cbTipoDeArchivo.Location = new System.Drawing.Point(37, 389);
            this.cbTipoDeArchivo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTipoDeArchivo.Name = "cbTipoDeArchivo";
            this.cbTipoDeArchivo.Size = new System.Drawing.Size(224, 24);
            this.cbTipoDeArchivo.TabIndex = 20;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "Tipo de archivo";
            // 
            // ReporteGasto
            // 
            chartArea1.AxisX.IntervalOffsetType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Number;
            chartArea1.Name = "ChartArea1";
            this.ReporteGasto.ChartAreas.Add(chartArea1);
            this.ReporteGasto.Location = new System.Drawing.Point(612, 87);
            this.ReporteGasto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ReporteGasto.Name = "ReporteGasto";
            series1.ChartArea = "ChartArea1";
            series1.Name = "S1";
            this.ReporteGasto.Series.Add(series1);
            this.ReporteGasto.Size = new System.Drawing.Size(556, 329);
            this.ReporteGasto.TabIndex = 24;
            this.ReporteGasto.Text = "ReporteGasto";
            title1.Font = new System.Drawing.Font("MS Reference Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Gasto Por Dia";
            title1.Text = "Gasto Por Dia";
            this.ReporteGasto.Titles.Add(title1);
            // 
            // ReporteDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReporteGasto);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbTipoDeArchivo);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tablaGastos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbMesAnio);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ReporteDeGastos";
            this.Size = new System.Drawing.Size(1683, 875);
            ((System.ComponentModel.ISupportInitialize)(this.ReporteGasto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbMesAnio;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label s;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView tablaGastos;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label lbTotal;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.ComboBox cbTipoDeArchivo;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataVisualization.Charting.Chart ReporteGasto;
    }
}
