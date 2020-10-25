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
            this.tbPalabraClave = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblPalabrasClave = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(25, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(311, 35);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Modificar Categoria";
            // 
            // cbCategorias
            // 
            this.cbCategorias.FormattingEnabled = true;
            this.cbCategorias.Location = new System.Drawing.Point(263, 89);
            this.cbCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCategorias.Name = "cbCategorias";
            this.cbCategorias.Size = new System.Drawing.Size(166, 28);
            this.cbCategorias.TabIndex = 16;
            this.cbCategorias.SelectedIndexChanged += new System.EventHandler(this.cbCategorias_SelectedIndexChanged);
            // 
            // lbCategorias
            // 
            this.lbCategorias.AutoSize = true;
            this.lbCategorias.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategorias.Location = new System.Drawing.Point(42, 87);
            this.lbCategorias.Name = "lbCategorias";
            this.lbCategorias.Size = new System.Drawing.Size(119, 26);
            this.lbCategorias.TabIndex = 17;
            this.lbCategorias.Text = "Categorias";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(446, 194);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(166, 44);
            this.btnEliminar.TabIndex = 30;
            this.btnEliminar.Text = "Eliminar Palabra";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbListaPalabrasClave
            // 
            this.cbListaPalabrasClave.FormattingEnabled = true;
            this.cbListaPalabrasClave.Location = new System.Drawing.Point(263, 196);
            this.cbListaPalabrasClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbListaPalabrasClave.Name = "cbListaPalabrasClave";
            this.cbListaPalabrasClave.Size = new System.Drawing.Size(166, 28);
            this.cbListaPalabrasClave.TabIndex = 29;
            // 
            // tbPalabraClave
            // 
            this.tbPalabraClave.Location = new System.Drawing.Point(263, 146);
            this.tbPalabraClave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPalabraClave.Name = "tbPalabraClave";
            this.tbPalabraClave.Size = new System.Drawing.Size(166, 26);
            this.tbPalabraClave.TabIndex = 28;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(446, 146);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(166, 35);
            this.btnAgregar.TabIndex = 27;
            this.btnAgregar.Text = "Agregar Palabra";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblPalabrasClave
            // 
            this.lblPalabrasClave.AutoSize = true;
            this.lblPalabrasClave.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPalabrasClave.Location = new System.Drawing.Point(3, 194);
            this.lblPalabrasClave.Name = "lblPalabrasClave";
            this.lblPalabrasClave.Size = new System.Drawing.Size(245, 26);
            this.lblPalabrasClave.TabIndex = 26;
            this.lblPalabrasClave.Text = "Lista de Palabras Clave";
            // 
            // ModificarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.cbListaPalabrasClave);
            this.Controls.Add(this.tbPalabraClave);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPalabrasClave);
            this.Controls.Add(this.lbCategorias);
            this.Controls.Add(this.cbCategorias);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ModificarCategoria";
            this.Size = new System.Drawing.Size(637, 273);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ComboBox cbCategorias;
        private System.Windows.Forms.Label lbCategorias;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbListaPalabrasClave;
        private System.Windows.Forms.TextBox tbPalabraClave;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblPalabrasClave;
    }
}
