namespace Interfaz_De_Usuario
{
    partial class MenuArribaMoneda
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panelNuevo = new System.Windows.Forms.Panel();
            this.btnEliminarMoneda = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Beige;
            this.btnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(48, 37);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(232, 33);
            this.btnAgregar.TabIndex = 3;
            this.btnAgregar.Text = "Agregar Moneda";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panelNuevo
            // 
            this.panelNuevo.Location = new System.Drawing.Point(48, 102);
            this.panelNuevo.Margin = new System.Windows.Forms.Padding(4);
            this.panelNuevo.Name = "panelNuevo";
            this.panelNuevo.Size = new System.Drawing.Size(827, 535);
            this.panelNuevo.TabIndex = 4;
            // 
            // btnEliminarMoneda
            // 
            this.btnEliminarMoneda.BackColor = System.Drawing.Color.Beige;
            this.btnEliminarMoneda.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarMoneda.Location = new System.Drawing.Point(569, 37);
            this.btnEliminarMoneda.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarMoneda.Name = "btnEliminarMoneda";
            this.btnEliminarMoneda.Size = new System.Drawing.Size(232, 33);
            this.btnEliminarMoneda.TabIndex = 5;
            this.btnEliminarMoneda.Text = "Eliminar Moneda";
            this.btnEliminarMoneda.UseVisualStyleBackColor = false;
            this.btnEliminarMoneda.Click += new System.EventHandler(this.btnEliminarMoneda_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Beige;
            this.btnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(311, 37);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(232, 33);
            this.btnModificar.TabIndex = 6;
            this.btnModificar.Text = "Modificar Moneda";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // MenuArribaMoneda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnEliminarMoneda);
            this.Controls.Add(this.panelNuevo);
            this.Controls.Add(this.btnAgregar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MenuArribaMoneda";
            this.Size = new System.Drawing.Size(1300, 1000);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Panel panelNuevo;
        private System.Windows.Forms.Button btnEliminarMoneda;
        private System.Windows.Forms.Button btnModificar;
    }
}
