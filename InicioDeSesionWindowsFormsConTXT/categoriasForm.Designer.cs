namespace InicioDeSesionWindowsFormsConTXT
{
    partial class categoriasForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxNombreCategoria = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAgregarCategoria = new FontAwesome.Sharp.IconButton();
            this.dataGridViewCategorias = new System.Windows.Forms.DataGridView();
            this.btnCargarEdicionCategoria = new FontAwesome.Sharp.IconButton();
            this.btnActualizarCategoria = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCategoria = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAsociarProductoACategoria = new FontAwesome.Sharp.IconButton();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(28, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Agregar Categoria";
            // 
            // textBoxNombreCategoria
            // 
            this.textBoxNombreCategoria.Location = new System.Drawing.Point(33, 102);
            this.textBoxNombreCategoria.Name = "textBoxNombreCategoria";
            this.textBoxNombreCategoria.Size = new System.Drawing.Size(149, 20);
            this.textBoxNombreCategoria.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(28, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre Categoria:";
            // 
            // btnAgregarCategoria
            // 
            this.btnAgregarCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarCategoria.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCategoria.Location = new System.Drawing.Point(254, 87);
            this.btnAgregarCategoria.Name = "btnAgregarCategoria";
            this.btnAgregarCategoria.Size = new System.Drawing.Size(146, 35);
            this.btnAgregarCategoria.TabIndex = 11;
            this.btnAgregarCategoria.Text = "Agregar Categoria";
            this.btnAgregarCategoria.UseVisualStyleBackColor = true;
            this.btnAgregarCategoria.Click += new System.EventHandler(this.btnAgregarCategoria_Click);
            // 
            // dataGridViewCategorias
            // 
            this.dataGridViewCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategorias.Location = new System.Drawing.Point(642, 26);
            this.dataGridViewCategorias.Name = "dataGridViewCategorias";
            this.dataGridViewCategorias.Size = new System.Drawing.Size(218, 436);
            this.dataGridViewCategorias.TabIndex = 12;
            // 
            // btnCargarEdicionCategoria
            // 
            this.btnCargarEdicionCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCargarEdicionCategoria.IconColor = System.Drawing.Color.Black;
            this.btnCargarEdicionCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarEdicionCategoria.Location = new System.Drawing.Point(692, 495);
            this.btnCargarEdicionCategoria.Name = "btnCargarEdicionCategoria";
            this.btnCargarEdicionCategoria.Size = new System.Drawing.Size(146, 35);
            this.btnCargarEdicionCategoria.TabIndex = 13;
            this.btnCargarEdicionCategoria.Text = "Cargar para edicion";
            this.btnCargarEdicionCategoria.UseVisualStyleBackColor = true;
            this.btnCargarEdicionCategoria.Click += new System.EventHandler(this.btnCargarEdicionCategoria_Click);
            // 
            // btnActualizarCategoria
            // 
            this.btnActualizarCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActualizarCategoria.IconColor = System.Drawing.Color.Black;
            this.btnActualizarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarCategoria.Location = new System.Drawing.Point(438, 87);
            this.btnActualizarCategoria.Name = "btnActualizarCategoria";
            this.btnActualizarCategoria.Size = new System.Drawing.Size(146, 35);
            this.btnActualizarCategoria.TabIndex = 14;
            this.btnActualizarCategoria.Text = "Actualizar Categoria";
            this.btnActualizarCategoria.UseVisualStyleBackColor = true;
            this.btnActualizarCategoria.Click += new System.EventHandler(this.btnActualizarCategoria_Click);
            // 
            // btnEliminarCategoria
            // 
            this.btnEliminarCategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarCategoria.IconColor = System.Drawing.Color.Black;
            this.btnEliminarCategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCategoria.Location = new System.Drawing.Point(692, 553);
            this.btnEliminarCategoria.Name = "btnEliminarCategoria";
            this.btnEliminarCategoria.Size = new System.Drawing.Size(146, 35);
            this.btnEliminarCategoria.TabIndex = 15;
            this.btnEliminarCategoria.Text = "Eliminar";
            this.btnEliminarCategoria.UseVisualStyleBackColor = true;
            this.btnEliminarCategoria.Click += new System.EventHandler(this.btnEliminarCategoria_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(24, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 25);
            this.label3.TabIndex = 16;
            this.label3.Text = "Organizar Productos por categoria";
            // 
            // btnAsociarProductoACategoria
            // 
            this.btnAsociarProductoACategoria.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAsociarProductoACategoria.IconColor = System.Drawing.Color.Black;
            this.btnAsociarProductoACategoria.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAsociarProductoACategoria.Location = new System.Drawing.Point(54, 544);
            this.btnAsociarProductoACategoria.Name = "btnAsociarProductoACategoria";
            this.btnAsociarProductoACategoria.Size = new System.Drawing.Size(146, 35);
            this.btnAsociarProductoACategoria.TabIndex = 19;
            this.btnAsociarProductoACategoria.Text = "Asociar Productos";
            this.btnAsociarProductoACategoria.UseVisualStyleBackColor = true;
            this.btnAsociarProductoACategoria.Click += new System.EventHandler(this.btnAsociarProductoACategoria_Click);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(42, 191);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(482, 246);
            this.dataGridViewProductos.TabIndex = 20;
            // 
            // iconButton1
            // 
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.Location = new System.Drawing.Point(920, 191);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(146, 35);
            this.iconButton1.TabIndex = 21;
            this.iconButton1.Text = "Ver Productos por Categoria";
            this.iconButton1.UseVisualStyleBackColor = true;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // categoriasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1121, 612);
            this.Controls.Add(this.iconButton1);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.btnAsociarProductoACategoria);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnEliminarCategoria);
            this.Controls.Add(this.btnActualizarCategoria);
            this.Controls.Add(this.btnCargarEdicionCategoria);
            this.Controls.Add(this.dataGridViewCategorias);
            this.Controls.Add(this.btnAgregarCategoria);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxNombreCategoria);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "categoriasForm";
            this.Text = "categoriasForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxNombreCategoria;
        private System.Windows.Forms.Label label2;
        private FontAwesome.Sharp.IconButton btnAgregarCategoria;
        private System.Windows.Forms.DataGridView dataGridViewCategorias;
        private FontAwesome.Sharp.IconButton btnCargarEdicionCategoria;
        private FontAwesome.Sharp.IconButton btnActualizarCategoria;
        private FontAwesome.Sharp.IconButton btnEliminarCategoria;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnAsociarProductoACategoria;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}