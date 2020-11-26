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
            this.cbCategorias = new System.Windows.Forms.ComboBox();
            this.lbCategorias = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbListaPalabrasClave = new System.Windows.Forms.ComboBox();
            this.lblPalabrasClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(17, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(215, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modificar Categoria";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(210, 58);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(174, 21);
            this.cbCategorias.TabIndex = 16;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.Location = new System.Drawing.Point(23, 57);
            this.lbCategorias.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(180, 18);
            this.lbCategorias.TabIndex = 17;
            this.lbCategorias.Text = "Seleccione una categoria";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(274, 135);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(109, 23);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar palabra";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbListaPalabrasClave
            // 
            this.cbListaPalabrasClave.FormattingEnabled = true;
            this.cbListaPalabrasClave.Location = new System.Drawing.Point(210, 109);
            this.cbListaPalabrasClave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.cbListaPalabrasClave.Name = "cbListaPalabrasClave";
            this.cbListaPalabrasClave.Size = new System.Drawing.Size(174, 21);
            this.cbListaPalabrasClave.TabIndex = 29;
            // 
            // lblPalabrasClave
            // 
            this.lblPalabrasClave.AutoSize = true;
            this.lblPalabrasClave.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabrasClave.Location = new System.Drawing.Point(23, 110);
            this.lblPalabrasClave.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPalabrasClave.Name = "lblPalabrasClave";
            this.lblPalabrasClave.Size = new System.Drawing.Size(167, 18);
            this.lblPalabrasClave.TabIndex = 26;
            this.lblPalabrasClave.Text = "Eliminar Palabras Clave";
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbListaPalabrasClave);
            this.Controls.Add(this.lblPalabrasClave);
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.Name = "ModificarCategoria";
            this.Size = new System.Drawing.Size(510, 278);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbListaPalabrasClave;
        private System.Windows.Forms.Label lblPalabrasClave;
    }
}
