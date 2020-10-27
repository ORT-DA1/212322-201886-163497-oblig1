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
            this.lbTotal = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(16, 20);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(293, 35);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Reporte de Gastos";
            // 
            // cbMesAnio
            // 
            this.cbMesAnio.FormattingEnabled = true;
            this.cbMesAnio.Location = new System.Drawing.Point(98, 95);
            this.cbMesAnio.Name = "cbMesAnio";
            this.cbMesAnio.Size = new System.Drawing.Size(250, 28);
            this.cbMesAnio.TabIndex = 11;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(377, 86);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(139, 41);
            this.btnConsultar.TabIndex = 12;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(27, 93);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(51, 26);
            this.lblMes.TabIndex = 13;
            this.lblMes.Text = "Mes";
            // 
            // s
            // 
            this.s.AutoSize = true;
            this.s.Location = new System.Drawing.Point(480, 466);
            this.s.Name = "s";
            this.s.Size = new System.Drawing.Size(107, 20);
            this.s.TabIndex = 15;
            this.s.Text = "Total del mes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(593, 466);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 16;
            // 
            // tablaGastos
            // 
            this.tablaGastos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.tablaGastos.GridLines = true;
            this.tablaGastos.HideSelection = false;
            this.tablaGastos.Location = new System.Drawing.Point(42, 177);
            this.tablaGastos.Name = "tablaGastos";
            this.tablaGastos.Size = new System.Drawing.Size(735, 261);
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
            this.columnHeader4.Width = 197;
            // 
            // lbTotal
            // 
            this.lbTotal.AutoSize = true;
            this.lbTotal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTotal.Location = new System.Drawing.Point(599, 466);
            this.lbTotal.Name = "lbTotal";
            this.lbTotal.Size = new System.Drawing.Size(54, 20);
            this.lbTotal.TabIndex = 18;
            this.lbTotal.Text = "monto";
            // 
            // ReporteDeGastos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbTotal);
            this.Controls.Add(this.tablaGastos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.s);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbMesAnio);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReporteDeGastos";
            this.Size = new System.Drawing.Size(888, 540);
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
    }
}
