namespace Interfaz_De_Usuario
{
    partial class CrearPresupuesto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbMes = new System.Windows.Forms.ComboBox();
            this.nudAnio = new System.Windows.Forms.NumericUpDown();
            this.btnCrearPresupuesto = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear presupuesto para mes: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(183, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Anio:";
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
            this.cbMes.Location = new System.Drawing.Point(230, 44);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(86, 24);
            this.cbMes.TabIndex = 2;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(230, 89);
            this.nudAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(86, 22);
            this.nudAnio.TabIndex = 3;
            // 
            // btnCrearPresupuesto
            // 
            this.btnCrearPresupuesto.Location = new System.Drawing.Point(344, 89);
            this.btnCrearPresupuesto.Name = "btnCrearPresupuesto";
            this.btnCrearPresupuesto.Size = new System.Drawing.Size(143, 28);
            this.btnCrearPresupuesto.TabIndex = 4;
            this.btnCrearPresupuesto.Text = "Crear presupuesto";
            this.btnCrearPresupuesto.UseVisualStyleBackColor = true;
            this.btnCrearPresupuesto.Click += new System.EventHandler(this.btnCrearPresupuesto_Click);
            // 
            // CrearPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCrearPresupuesto);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "CrearPresupuesto";
            this.Size = new System.Drawing.Size(522, 431);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnCrearPresupuesto;
    }
}
