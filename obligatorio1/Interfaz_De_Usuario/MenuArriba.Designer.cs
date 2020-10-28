namespace Interfaz_De_Usuario
{
    partial class MenuArribaCategoria
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
            this.btnAgregarCatMenuArriba = new System.Windows.Forms.Button();
            this.panelNuevo = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAgregarCatMenuArriba
            // 
            this.btnAgregarCatMenuArriba.BackColor = System.Drawing.Color.Beige;
            this.btnAgregarCatMenuArriba.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarCatMenuArriba.Location = new System.Drawing.Point(59, 27);
            this.btnAgregarCatMenuArriba.Name = "btnAgregarCatMenuArriba";
            this.btnAgregarCatMenuArriba.Size = new System.Drawing.Size(266, 41);
            this.btnAgregarCatMenuArriba.TabIndex = 0;
            this.btnAgregarCatMenuArriba.Text = "Agregar Categoria";
            this.btnAgregarCatMenuArriba.UseVisualStyleBackColor = false;
            this.btnAgregarCatMenuArriba.Click += new System.EventHandler(this.btnAgregarCatMenuArriba_Click);
            // 
            // panelNuevo
            // 
            this.panelNuevo.Location = new System.Drawing.Point(59, 103);
            this.panelNuevo.Name = "panelNuevo";
            this.panelNuevo.Size = new System.Drawing.Size(946, 538);
            this.panelNuevo.TabIndex = 1;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Beige;
            this.btnModificar.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(373, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(261, 41);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar Categoria";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // MenuArribaCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.panelNuevo);
            this.Controls.Add(this.btnAgregarCatMenuArriba);
            this.Name = "MenuArribaCategoria";
            this.Size = new System.Drawing.Size(1069, 687);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarCatMenuArriba;
        private System.Windows.Forms.Panel panelNuevo;
        private System.Windows.Forms.Button btnModificar;
    }
}
