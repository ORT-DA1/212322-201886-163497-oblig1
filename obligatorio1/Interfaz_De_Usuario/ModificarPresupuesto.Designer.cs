namespace Interfaz_De_Usuario
{
    partial class ModificarPresupuesto
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
            this.btnSeleccionarPresupuesto = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.hdrCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnModificarMonto = new System.Windows.Forms.Button();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            this.cbMesAnio = new System.Windows.Forms.ComboBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarPresupuesto
            // 
            this.btnSeleccionarPresupuesto.AutoSize = true;
            this.btnSeleccionarPresupuesto.Location = new System.Drawing.Point(11, 36);
            this.btnSeleccionarPresupuesto.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.btnSeleccionarPresupuesto.Name = "btnSeleccionarPresupuesto";
            this.btnSeleccionarPresupuesto.Size = new System.Drawing.Size(136, 13);
            this.btnSeleccionarPresupuesto.TabIndex = 0;
            this.btnSeleccionarPresupuesto.Text = "Selccionar un presupuesto:";
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrCategoria,
            this.hdrMonto});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(14, 107);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(265, 185);
            this.listView1.TabIndex = 6;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // hdrCategoria
            // 
            this.hdrCategoria.Text = "Categoria";
            this.hdrCategoria.Width = 134;
            // 
            // hdrMonto
            // 
            this.hdrMonto.Text = "Monto";
            this.hdrMonto.Width = 143;
            // 
            // btnModificarMonto
            // 
            this.btnModificarMonto.Location = new System.Drawing.Point(300, 140);
            this.btnModificarMonto.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarMonto.Name = "btnModificarMonto";
            this.btnModificarMonto.Size = new System.Drawing.Size(107, 22);
            this.btnModificarMonto.TabIndex = 9;
            this.btnModificarMonto.Text = "Modificar monto";
            this.btnModificarMonto.UseVisualStyleBackColor = true;
            this.btnModificarMonto.Click += new System.EventHandler(this.btnModificarMonto_Click);
            // 
            // nudMonto
            // 
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Location = new System.Drawing.Point(300, 116);
            this.nudMonto.Margin = new System.Windows.Forms.Padding(2);
            this.nudMonto.Maximum = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(107, 20);
            this.nudMonto.TabIndex = 10;
            // 
            // cbMesAnio
            // 
            this.cbMesAnio.FormattingEnabled = true;
            this.cbMesAnio.Location = new System.Drawing.Point(14, 66);
            this.cbMesAnio.Margin = new System.Windows.Forms.Padding(2);
            this.cbMesAnio.Name = "cbMesAnio";
            this.cbMesAnio.Size = new System.Drawing.Size(168, 21);
            this.cbMesAnio.TabIndex = 12;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultar.Location = new System.Drawing.Point(186, 62);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(93, 27);
            this.btnConsultar.TabIndex = 13;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // ModificarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.cbMesAnio);
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.btnModificarMonto);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSeleccionarPresupuesto);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ModificarPresupuesto";
            this.Size = new System.Drawing.Size(445, 332);
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSeleccionarPresupuesto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader hdrCategoria;
        private System.Windows.Forms.ColumnHeader hdrMonto;
        private System.Windows.Forms.Button btnModificarMonto;
        private System.Windows.Forms.NumericUpDown nudMonto;
        private System.Windows.Forms.ComboBox cbMesAnio;
        private System.Windows.Forms.Button btnConsultar;
    }
}
