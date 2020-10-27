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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.btnCrearPresupuesto2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(18, 65);
            this.dtFecha.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dtFecha.MaxDate = new System.DateTime(2030, 12, 31, 0, 0, 0, 0);
            this.dtFecha.MinDate = new System.DateTime(2018, 1, 1, 0, 0, 0, 0);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(212, 20);
            this.dtFecha.TabIndex = 24;
            // 
            // btnCrearPresupuesto2
            // 
            this.btnCrearPresupuesto2.Location = new System.Drawing.Point(262, 66);
            this.btnCrearPresupuesto2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCrearPresupuesto2.Name = "btnCrearPresupuesto2";
            this.btnCrearPresupuesto2.Size = new System.Drawing.Size(107, 23);
            this.btnCrearPresupuesto2.TabIndex = 26;
            this.btnCrearPresupuesto2.Text = "Crear presupuesto";
            this.btnCrearPresupuesto2.UseVisualStyleBackColor = true;
            this.btnCrearPresupuesto2.Click += new System.EventHandler(this.btnCrearPresupuesto2_Click);
            // 
            // CrearPresupuesto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCrearPresupuesto2);
            this.Controls.Add(this.dtFecha);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "CrearPresupuesto";
            this.Size = new System.Drawing.Size(392, 165);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Button btnCrearPresupuesto2;
    }
}
