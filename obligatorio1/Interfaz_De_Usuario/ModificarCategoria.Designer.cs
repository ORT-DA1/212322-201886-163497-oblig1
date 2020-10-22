namespace Interfaz_De_Usuario
{
    partial class ModificarCategoria
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
            this.lblPalabrasClave = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.tbPalabraClave = new System.Windows.Forms.TextBox();
            this.pListaPalabarasClave = new System.Windows.Forms.Panel();
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(106, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(311, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modificar Categoria";
            // 
            // lblPalabrasClave
            // 
            this.lblPalabrasClave.AutoSize = true;
            this.lblPalabrasClave.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabrasClave.Location = new System.Drawing.Point(12, 261);
            this.lblPalabrasClave.Name = "lblPalabrasClave";
            this.lblPalabrasClave.Size = new System.Drawing.Size(160, 26);
            this.lblPalabrasClave.TabIndex = 2;
            this.lblPalabrasClave.Text = "Palabras Clave";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(17, 182);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(109, 37);
            this.btnAgregar.TabIndex = 13;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // tbPalabraClave
            // 
            this.tbPalabraClave.Location = new System.Drawing.Point(190, 193);
            this.tbPalabraClave.Name = "tbPalabraClave";
            this.tbPalabraClave.Size = new System.Drawing.Size(166, 26);
            this.tbPalabraClave.TabIndex = 14;
            // 
            // pListaPalabarasClave
            // 
            this.pListaPalabarasClave.Location = new System.Drawing.Point(141, 314);
            this.pListaPalabarasClave.Name = "pListaPalabarasClave";
            this.pListaPalabarasClave.Size = new System.Drawing.Size(258, 374);
            this.pListaPalabarasClave.TabIndex = 15;
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(190, 116);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(166, 28);
            this.cbCategorias.TabIndex = 16;
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.Location = new System.Drawing.Point(12, 116);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(119, 26);
            this.lbCategorias.TabIndex = 17;
            this.lbCategorias.Text = "Categorias";
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.pListaPalabarasClave);
            this.Controls.Add(this.tbPalabraClave);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPalabrasClave);
            this.Controls.Add(this.lblTitulo);
            this.Name = "ModificarCategoria";
            this.Size = new System.Drawing.Size(566, 715);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblPalabrasClave;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox tbPalabraClave;
        private System.Windows.Forms.Panel pListaPalabarasClave;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lbCategorias;
    }
}
