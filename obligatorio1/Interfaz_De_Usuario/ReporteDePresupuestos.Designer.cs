namespace Interfaz_De_Usuario
{
    partial class ReporteDePresupuestos
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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.tpReporteGastos = new System.Windows.Forms.TableLayoutPanel();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblPlanificado = new System.Windows.Forms.Label();
            this.lblReal = new System.Windows.Forms.Label();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblDiferencia = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tpReporteGastos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(28, 28);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(375, 35);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "Reporte de Presupuesto";
            // 
            // cbMes
            // 
            this.cbMes.FormattingEnabled = true;
            this.cbMes.Location = new System.Drawing.Point(132, 95);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(250, 28);
            this.cbMes.TabIndex = 14;
            // 
            // tpReporteGastos
            // 
            this.tpReporteGastos.AccessibleDescription = "";
            this.tpReporteGastos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.tpReporteGastos.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tpReporteGastos.ColumnCount = 4;
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.03497F));
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.75525F));
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpReporteGastos.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpReporteGastos.Controls.Add(this.listView1, 0, 1);
            this.tpReporteGastos.Controls.Add(this.lblTotal, 0, 3);
            this.tpReporteGastos.Controls.Add(this.lblCategoria, 0, 0);
            this.tpReporteGastos.Controls.Add(this.lblPlanificado, 1, 0);
            this.tpReporteGastos.Controls.Add(this.lblReal, 2, 0);
            this.tpReporteGastos.Controls.Add(this.lblDiferencia, 3, 0);
            this.tpReporteGastos.Location = new System.Drawing.Point(34, 177);
            this.tpReporteGastos.Name = "tpReporteGastos";
            this.tpReporteGastos.RowCount = 3;
            this.tpReporteGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 18.69919F));
            this.tpReporteGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 31.16531F));
            this.tpReporteGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 29.09535F));
            this.tpReporteGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.0269F));
            this.tpReporteGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tpReporteGastos.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpReporteGastos.Size = new System.Drawing.Size(716, 410);
            this.tpReporteGastos.TabIndex = 16;
            this.tpReporteGastos.Tag = "";
            // 
            // lblCategoria
            // 
            this.lblCategoria.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(35, 22);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(109, 26);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblPlanificado
            // 
            this.lblPlanificado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPlanificado.AutoSize = true;
            this.lblPlanificado.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanificado.Location = new System.Drawing.Point(209, 22);
            this.lblPlanificado.Name = "lblPlanificado";
            this.lblPlanificado.Size = new System.Drawing.Size(120, 26);
            this.lblPlanificado.TabIndex = 22;
            this.lblPlanificado.Text = "Planificado";
            // 
            // lblReal
            // 
            this.lblReal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblReal.AutoSize = true;
            this.lblReal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReal.Location = new System.Drawing.Point(419, 22);
            this.lblReal.Name = "lblReal";
            this.lblReal.Size = new System.Drawing.Size(56, 26);
            this.lblReal.TabIndex = 23;
            this.lblReal.Text = "Real";
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(29, 98);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(51, 26);
            this.lblMes.TabIndex = 17;
            this.lblMes.Text = "Mes";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(417, 95);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(104, 35);
            this.btnConsultar.TabIndex = 18;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.Location = new System.Drawing.Point(59, 376);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(62, 26);
            this.lblTotal.TabIndex = 25;
            this.lblTotal.Text = "Total";
            // 
            // lblDiferencia
            // 
            this.lblDiferencia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblDiferencia.AutoSize = true;
            this.lblDiferencia.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiferencia.Location = new System.Drawing.Point(568, 22);
            this.lblDiferencia.Name = "lblDiferencia";
            this.lblDiferencia.Size = new System.Drawing.Size(114, 26);
            this.lblDiferencia.TabIndex = 24;
            this.lblDiferencia.Text = "Diferencia";
            // 
            // listView1
            // 
            this.tpReporteGastos.SetColumnSpan(this.listView1, 4);
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(4, 73);
            this.listView1.Name = "listView1";
            this.tpReporteGastos.SetRowSpan(this.listView1, 3);
            this.listView1.Size = new System.Drawing.Size(708, 293);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // ReporteDePresupuestos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.tpReporteGastos);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ReporteDePresupuestos";
            this.Size = new System.Drawing.Size(830, 632);
            this.tpReporteGastos.ResumeLayout(false);
            this.tpReporteGastos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.TableLayoutPanel tpReporteGastos;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblPlanificado;
        private System.Windows.Forms.Label lblReal;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblDiferencia;
        private System.Windows.Forms.ListView listView1;
    }
}
