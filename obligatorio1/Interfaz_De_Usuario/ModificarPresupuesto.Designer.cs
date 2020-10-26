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
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnVerPresupuesto = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.hdrCategoria = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.hdrMonto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblMes = new System.Windows.Forms.Label();
            this.lblAnio = new System.Windows.Forms.Label();
            this.btnModificarMonto = new System.Windows.Forms.Button();
            this.nudMonto = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarPresupuesto
            // 
            this.btnSeleccionarPresupuesto.AutoSize = true;
            this.btnSeleccionarPresupuesto.Location = new System.Drawing.Point(34, 36);
            this.btnSeleccionarPresupuesto.Name = "btnSeleccionarPresupuesto";
            this.btnSeleccionarPresupuesto.Size = new System.Drawing.Size(181, 17);
            this.btnSeleccionarPresupuesto.TabIndex = 0;
            this.btnSeleccionarPresupuesto.Text = "Selccionar un presupuesto:";
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
            this.cbMes.Location = new System.Drawing.Point(64, 87);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(120, 24);
            this.cbMes.TabIndex = 3;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(190, 89);
            this.nudAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(113, 22);
            this.nudAnio.TabIndex = 4;
            // 
            // btnVerPresupuesto
            // 
            this.btnVerPresupuesto.Location = new System.Drawing.Point(319, 84);
            this.btnVerPresupuesto.Name = "btnVerPresupuesto";
            this.btnVerPresupuesto.Size = new System.Drawing.Size(143, 28);
            this.btnVerPresupuesto.TabIndex = 5;
            this.btnVerPresupuesto.Text = "Ver presupuesto";
            this.btnVerPresupuesto.UseVisualStyleBackColor = true;
            this.btnVerPresupuesto.Click += new System.EventHandler(this.btnVerPresupuesto_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.hdrCategoria,
            this.hdrMonto});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(64, 143);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(239, 227);
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
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Location = new System.Drawing.Point(61, 67);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(38, 17);
            this.lblMes.TabIndex = 7;
            this.lblMes.Text = "Mes:";
            // 
            // lblAnio
            // 
            this.lblAnio.AutoSize = true;
            this.lblAnio.Location = new System.Drawing.Point(187, 67);
            this.lblAnio.Name = "lblAnio";
            this.lblAnio.Size = new System.Drawing.Size(37, 17);
            this.lblAnio.TabIndex = 8;
            this.lblAnio.Text = "Año:";
            // 
            // btnModificarMonto
            // 
            this.btnModificarMonto.Location = new System.Drawing.Point(319, 171);
            this.btnModificarMonto.Name = "btnModificarMonto";
            this.btnModificarMonto.Size = new System.Drawing.Size(143, 27);
            this.btnModificarMonto.TabIndex = 9;
            this.btnModificarMonto.Text = "Modificar monto";
            this.btnModificarMonto.UseVisualStyleBackColor = true;
            this.btnModificarMonto.Click += new System.EventHandler(this.btnModificarMonto_Click);
            // 
            // nudMonto
            // 
            this.nudMonto.DecimalPlaces = 2;
            this.nudMonto.Location = new System.Drawing.Point(319, 143);
            this.nudMonto.Maximum = new decimal(new int[] {
            9000000,
            0,
            0,
            0});
            this.nudMonto.Name = "nudMonto";
            this.nudMonto.Size = new System.Drawing.Size(143, 22);
            this.nudMonto.TabIndex = 10;
            // 
            // ModificarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.nudMonto);
            this.Controls.Add(this.btnModificarMonto);
            this.Controls.Add(this.lblAnio);
            this.Controls.Add(this.lblMes);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.btnSeleccionarPresupuesto);
            this.Name = "ModificarPresupuesto";
            this.Size = new System.Drawing.Size(523, 409);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSeleccionarPresupuesto;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnVerPresupuesto;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader hdrCategoria;
        private System.Windows.Forms.ColumnHeader hdrMonto;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.Label lblAnio;
        private System.Windows.Forms.Button btnModificarMonto;
        private System.Windows.Forms.NumericUpDown nudMonto;
    }
}
