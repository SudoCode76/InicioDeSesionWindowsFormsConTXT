namespace InicioDeSesionWindowsFormsConTXT
{
    partial class facturarForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.btnAgregarProductoAFactura = new FontAwesome.Sharp.IconButton();
            this.btnFinalizarCompra = new FontAwesome.Sharp.IconButton();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.dataGridViewDetalleFactura = new System.Windows.Forms.DataGridView();
            this.numericCantidad = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(450, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facturar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(34, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Cliente";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(34, 277);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Productos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(557, 75);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Detalle Factura";
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(38, 122);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(447, 126);
            this.dataGridViewClientes.TabIndex = 11;
            // 
            // btnAgregarProductoAFactura
            // 
            this.btnAgregarProductoAFactura.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarProductoAFactura.IconColor = System.Drawing.Color.Black;
            this.btnAgregarProductoAFactura.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarProductoAFactura.Location = new System.Drawing.Point(510, 381);
            this.btnAgregarProductoAFactura.Name = "btnAgregarProductoAFactura";
            this.btnAgregarProductoAFactura.Size = new System.Drawing.Size(117, 35);
            this.btnAgregarProductoAFactura.TabIndex = 12;
            this.btnAgregarProductoAFactura.Text = "Agregar Producto";
            this.btnAgregarProductoAFactura.UseVisualStyleBackColor = true;
            this.btnAgregarProductoAFactura.Click += new System.EventHandler(this.btnAgregarProductoAFactura_Click_1);
            // 
            // btnFinalizarCompra
            // 
            this.btnFinalizarCompra.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnFinalizarCompra.IconColor = System.Drawing.Color.Black;
            this.btnFinalizarCompra.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFinalizarCompra.Location = new System.Drawing.Point(510, 439);
            this.btnFinalizarCompra.Name = "btnFinalizarCompra";
            this.btnFinalizarCompra.Size = new System.Drawing.Size(117, 35);
            this.btnFinalizarCompra.TabIndex = 13;
            this.btnFinalizarCompra.Text = "Finalizar Compra";
            this.btnFinalizarCompra.UseVisualStyleBackColor = true;
            this.btnFinalizarCompra.Click += new System.EventHandler(this.btnFinalizarCompra_Click_1);
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToOrderColumns = true;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Location = new System.Drawing.Point(39, 315);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(446, 250);
            this.dataGridViewProductos.TabIndex = 15;
            // 
            // dataGridViewDetalleFactura
            // 
            this.dataGridViewDetalleFactura.AllowUserToOrderColumns = true;
            this.dataGridViewDetalleFactura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDetalleFactura.Location = new System.Drawing.Point(562, 122);
            this.dataGridViewDetalleFactura.Name = "dataGridViewDetalleFactura";
            this.dataGridViewDetalleFactura.Size = new System.Drawing.Size(502, 180);
            this.dataGridViewDetalleFactura.TabIndex = 16;
            // 
            // numericCantidad
            // 
            this.numericCantidad.Location = new System.Drawing.Point(507, 338);
            this.numericCantidad.Name = "numericCantidad";
            this.numericCantidad.Size = new System.Drawing.Size(120, 20);
            this.numericCantidad.TabIndex = 17;
            // 
            // facturarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1121, 612);
            this.Controls.Add(this.numericCantidad);
            this.Controls.Add(this.dataGridViewDetalleFactura);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.btnFinalizarCompra);
            this.Controls.Add(this.btnAgregarProductoAFactura);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "facturarForm";
            this.Text = "facturarForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDetalleFactura)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private FontAwesome.Sharp.IconButton btnAgregarProductoAFactura;
        private FontAwesome.Sharp.IconButton btnFinalizarCompra;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridView dataGridViewDetalleFactura;
        private System.Windows.Forms.NumericUpDown numericCantidad;
    }
}