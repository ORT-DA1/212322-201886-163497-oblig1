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
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionarPresupuesto
            // 
            this.btnSeleccionarPresupuesto.AutoSize = true;
            this.btnSeleccionarPresupuesto.Location = new System.Drawing.Point(32, 49);
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
            this.cbMes.Location = new System.Drawing.Point(52, 87);
            this.cbMes.Name = "cbMes";
            this.cbMes.Size = new System.Drawing.Size(86, 24);
            this.cbMes.TabIndex = 3;
            // 
            // nudAnio
            // 
            this.nudAnio.Location = new System.Drawing.Point(190, 87);
            this.nudAnio.Maximum = new decimal(new int[] {
            2030,
            0,
            0,
            0});
            this.nudAnio.Name = "nudAnio";
            this.nudAnio.Size = new System.Drawing.Size(86, 22);
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
            // ModificarPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnVerPresupuesto);
            this.Controls.Add(this.nudAnio);
            this.Controls.Add(this.cbMes);
            this.Controls.Add(this.btnSeleccionarPresupuesto);
            this.Name = "ModificarPresupuesto";
            this.Size = new System.Drawing.Size(523, 409);
            ((System.ComponentModel.ISupportInitialize)(this.nudAnio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label btnSeleccionarPresupuesto;
        private System.Windows.Forms.ComboBox cbMes;
        private System.Windows.Forms.NumericUpDown nudAnio;
        private System.Windows.Forms.Button btnVerPresupuesto;
    }
}
