namespace Interfaz_De_Usuario
{
    partial class ModificarMoneda
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
            this.cbMonedas = new System.Windows.Forms.ComboBox();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnModificarCotizacion = new System.Windows.Forms.Button();
            this.btnModificarSimbolo = new System.Windows.Forms.Button();
            this.btnModificarNombre = new System.Windows.Forms.Button();
            this.numCotizacion = new System.Windows.Forms.NumericUpDown();
            this.tbSimbolo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.lbNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numCotizacion)).BeginInit();
            this.SuspendLayout();
            // 
            // cbMonedas
            // 
            this.cbMonedas.FormattingEnabled = true;
            this.cbMonedas.Location = new System.Drawing.Point(135, 75);
            this.cbMonedas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbMonedas.Name = "cbMonedas";
            this.cbMonedas.Size = new System.Drawing.Size(231, 24);
            this.cbMonedas.TabIndex = 32;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 21);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(237, 29);
            this.lblTitulo.TabIndex = 31;
            this.lblTitulo.Text = "Modificar Moneda";
            // 
            // btnModificarCotizacion
            // 
            this.btnModificarCotizacion.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarCotizacion.Location = new System.Drawing.Point(394, 307);
            this.btnModificarCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarCotizacion.Name = "btnModificarCotizacion";
            this.btnModificarCotizacion.Size = new System.Drawing.Size(145, 28);
            this.btnModificarCotizacion.TabIndex = 68;
            this.btnModificarCotizacion.Text = "Modificar";
            this.btnModificarCotizacion.UseVisualStyleBackColor = true;
            this.btnModificarCotizacion.Click += new System.EventHandler(this.btnModificarCotizacion_Click_1);
            // 
            // btnModificarSimbolo
            // 
            this.btnModificarSimbolo.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarSimbolo.Location = new System.Drawing.Point(394, 247);
            this.btnModificarSimbolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarSimbolo.Name = "btnModificarSimbolo";
            this.btnModificarSimbolo.Size = new System.Drawing.Size(145, 28);
            this.btnModificarSimbolo.TabIndex = 67;
            this.btnModificarSimbolo.Text = "Modificar";
            this.btnModificarSimbolo.UseVisualStyleBackColor = true;
            this.btnModificarSimbolo.Click += new System.EventHandler(this.btnModificarSimbolo_Click_1);
            // 
            // btnModificarNombre
            // 
            this.btnModificarNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarNombre.Location = new System.Drawing.Point(394, 194);
            this.btnModificarNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarNombre.Name = "btnModificarNombre";
            this.btnModificarNombre.Size = new System.Drawing.Size(145, 28);
            this.btnModificarNombre.TabIndex = 66;
            this.btnModificarNombre.Text = "Modificar";
            this.btnModificarNombre.UseVisualStyleBackColor = true;
            this.btnModificarNombre.Click += new System.EventHandler(this.btnModificarNombre_Click_1);
            // 
            // numCotizacion
            // 
            this.numCotizacion.DecimalPlaces = 2;
            this.numCotizacion.Location = new System.Drawing.Point(135, 313);
            this.numCotizacion.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.numCotizacion.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numCotizacion.Name = "numCotizacion";
            this.numCotizacion.Size = new System.Drawing.Size(232, 22);
            this.numCotizacion.TabIndex = 65;
            // 
            // tbSimbolo
            // 
            this.tbSimbolo.Location = new System.Drawing.Point(135, 253);
            this.tbSimbolo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSimbolo.Name = "tbSimbolo";
            this.tbSimbolo.Size = new System.Drawing.Size(231, 22);
            this.tbSimbolo.TabIndex = 64;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 313);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 22);
            this.label2.TabIndex = 63;
            this.label2.Text = "Cotizacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 22);
            this.label1.TabIndex = 62;
            this.label1.Text = "Simbolo";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(135, 197);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(231, 22);
            this.tbNombre.TabIndex = 61;
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(43, 197);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(78, 22);
            this.lbNombre.TabIndex = 60;
            this.lbNombre.Text = "Nombre";
            // 
            // ModificarMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificarCotizacion);
            this.Controls.Add(this.btnModificarSimbolo);
            this.Controls.Add(this.btnModificarNombre);
            this.Controls.Add(this.numCotizacion);
            this.Controls.Add(this.tbSimbolo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.cbMonedas);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModificarMoneda";
            this.Size = new System.Drawing.Size(791, 585);
            ((System.ComponentModel.ISupportInitialize)(this.numCotizacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbMonedas;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnModificarCotizacion;
        private System.Windows.Forms.Button btnModificarSimbolo;
        private System.Windows.Forms.Button btnModificarNombre;
        private System.Windows.Forms.NumericUpDown numCotizacion;
        private System.Windows.Forms.TextBox tbSimbolo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Label lbNombre;
    }
}
