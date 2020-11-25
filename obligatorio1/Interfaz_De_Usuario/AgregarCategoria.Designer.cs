namespace Interfaz_De_Usuario
{
    partial class AgregarCategoria
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
            this.lbNombre = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listCategorias = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listPalabrasClave = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbPalabraClave = new System.Windows.Forms.TextBox();
            this.btnAgregarPClave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(30, 48);
            this.lbNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(170, 18);
            this.lbNombre.TabIndex = 20;
            this.lbNombre.Text = "Nombre de la categoria";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(29, 14);
            this.lblTitulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(200, 24);
            this.lblTitulo.TabIndex = 18;
            this.lblTitulo.Text = "Agregar Categoria";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(33, 78);
            this.tbNombre.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(239, 20);
            this.tbNombre.TabIndex = 21;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(299, 72);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(73, 31);
            this.btnAgregar.TabIndex = 22;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // listCategorias
            // 
            this.listCategorias.FormattingEnabled = true;
            this.listCategorias.Location = new System.Drawing.Point(26, 148);
            this.listCategorias.Name = "listCategorias";
            this.listCategorias.Size = new System.Drawing.Size(166, 134);
            this.listCategorias.TabIndex = 23;
            this.listCategorias.SelectedIndexChanged += new System.EventHandler(this.listCategorias_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 118);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 18);
            this.label1.TabIndex = 24;
            this.label1.Text = "Mis categorias";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(211, 118);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 18);
            this.label2.TabIndex = 26;
            this.label2.Text = "Palabras clave";
            // 
            // listPalabrasClave
            // 
            this.listPalabrasClave.FormattingEnabled = true;
            this.listPalabrasClave.Location = new System.Drawing.Point(214, 148);
            this.listPalabrasClave.Name = "listPalabrasClave";
            this.listPalabrasClave.Size = new System.Drawing.Size(166, 134);
            this.listPalabrasClave.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS Reference Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 302);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(159, 18);
            this.label3.TabIndex = 34;
            this.label3.Text = "Agregar palabra clave";
            // 
            // tbPalabraClave
            // 
            this.tbPalabraClave.Location = new System.Drawing.Point(26, 333);
            this.tbPalabraClave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.tbPalabraClave.Name = "tbPalabraClave";
            this.tbPalabraClave.Size = new System.Drawing.Size(156, 20);
            this.tbPalabraClave.TabIndex = 33;
            // 
            // btnAgregarPClave
            // 
            this.btnAgregarPClave.Font = new System.Drawing.Font("MS Reference Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarPClave.Location = new System.Drawing.Point(186, 330);
            this.btnAgregarPClave.Margin = new System.Windows.Forms.Padding(2, 1, 2, 1);
            this.btnAgregarPClave.Name = "btnAgregarPClave";
            this.btnAgregarPClave.Size = new System.Drawing.Size(100, 25);
            this.btnAgregarPClave.TabIndex = 35;
            this.btnAgregarPClave.Text = "Agregar palabra";
            this.btnAgregarPClave.UseVisualStyleBackColor = true;
            this.btnAgregarPClave.Click += new System.EventHandler(this.btnAgregarPClave_Click);
            // 
            // AgregarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarPClave);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbPalabraClave);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listPalabrasClave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listCategorias);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lblTitulo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AgregarCategoria";
            this.Size = new System.Drawing.Size(696, 412);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListBox listCategorias;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listPalabrasClave;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbPalabraClave;
        private System.Windows.Forms.Button btnAgregarPClave;
    }
}
