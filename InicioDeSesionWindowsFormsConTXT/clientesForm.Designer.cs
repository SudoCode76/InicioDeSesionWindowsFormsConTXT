namespace InicioDeSesionWindowsFormsConTXT
{
    partial class clientesForm
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
            this.textBoxNombreCliente = new System.Windows.Forms.TextBox();
            this.textBoxDireccionCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTelefonoCliente = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEmailCliente = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnAgregarCliente = new FontAwesome.Sharp.IconButton();
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.btnActualizarCliente = new FontAwesome.Sharp.IconButton();
            this.btnCargarEdicionCliente = new FontAwesome.Sharp.IconButton();
            this.btnEliminarCliente = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Agregar Cliente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre:";
            // 
            // textBoxNombreCliente
            // 
            this.textBoxNombreCliente.Location = new System.Drawing.Point(17, 104);
            this.textBoxNombreCliente.Name = "textBoxNombreCliente";
            this.textBoxNombreCliente.Size = new System.Drawing.Size(117, 20);
            this.textBoxNombreCliente.TabIndex = 3;
            // 
            // textBoxDireccionCliente
            // 
            this.textBoxDireccionCliente.Location = new System.Drawing.Point(198, 104);
            this.textBoxDireccionCliente.Name = "textBoxDireccionCliente";
            this.textBoxDireccionCliente.Size = new System.Drawing.Size(117, 20);
            this.textBoxDireccionCliente.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(193, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Direccion:";
            // 
            // textBoxTelefonoCliente
            // 
            this.textBoxTelefonoCliente.Location = new System.Drawing.Point(373, 104);
            this.textBoxTelefonoCliente.Name = "textBoxTelefonoCliente";
            this.textBoxTelefonoCliente.Size = new System.Drawing.Size(117, 20);
            this.textBoxTelefonoCliente.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(368, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Telefono:";
            // 
            // textBoxEmailCliente
            // 
            this.textBoxEmailCliente.Location = new System.Drawing.Point(530, 104);
            this.textBoxEmailCliente.Name = "textBoxEmailCliente";
            this.textBoxEmailCliente.Size = new System.Drawing.Size(117, 20);
            this.textBoxEmailCliente.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(525, 61);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Email:";
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnAgregarCliente.IconColor = System.Drawing.Color.Black;
            this.btnAgregarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAgregarCliente.Location = new System.Drawing.Point(740, 51);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(117, 35);
            this.btnAgregarCliente.TabIndex = 10;
            this.btnAgregarCliente.Text = "Agregar";
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToOrderColumns = true;
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(136, 152);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.Size = new System.Drawing.Size(819, 338);
            this.dataGridViewClientes.TabIndex = 11;
            // 
            // btnActualizarCliente
            // 
            this.btnActualizarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnActualizarCliente.IconColor = System.Drawing.Color.Black;
            this.btnActualizarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnActualizarCliente.Location = new System.Drawing.Point(740, 104);
            this.btnActualizarCliente.Name = "btnActualizarCliente";
            this.btnActualizarCliente.Size = new System.Drawing.Size(117, 35);
            this.btnActualizarCliente.TabIndex = 14;
            this.btnActualizarCliente.Text = "Actualizar";
            this.btnActualizarCliente.UseVisualStyleBackColor = true;
            this.btnActualizarCliente.Click += new System.EventHandler(this.btnActualizarCliente_Click);
            // 
            // btnCargarEdicionCliente
            // 
            this.btnCargarEdicionCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnCargarEdicionCliente.IconColor = System.Drawing.Color.Black;
            this.btnCargarEdicionCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCargarEdicionCliente.Location = new System.Drawing.Point(838, 534);
            this.btnCargarEdicionCliente.Name = "btnCargarEdicionCliente";
            this.btnCargarEdicionCliente.Size = new System.Drawing.Size(117, 35);
            this.btnCargarEdicionCliente.TabIndex = 16;
            this.btnCargarEdicionCliente.Text = "Cargar para Edición";
            this.btnCargarEdicionCliente.UseVisualStyleBackColor = true;
            this.btnCargarEdicionCliente.Click += new System.EventHandler(this.btnCargarEdicionCliente_Click);
            // 
            // btnEliminarCliente
            // 
            this.btnEliminarCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.btnEliminarCliente.IconColor = System.Drawing.Color.Black;
            this.btnEliminarCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminarCliente.Location = new System.Drawing.Point(136, 534);
            this.btnEliminarCliente.Name = "btnEliminarCliente";
            this.btnEliminarCliente.Size = new System.Drawing.Size(117, 35);
            this.btnEliminarCliente.TabIndex = 15;
            this.btnEliminarCliente.Text = "Eliminar";
            this.btnEliminarCliente.UseVisualStyleBackColor = true;
            this.btnEliminarCliente.Click += new System.EventHandler(this.btnEliminarCliente_Click);
            // 
            // clientesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(54)))), ((int)(((byte)(53)))));
            this.ClientSize = new System.Drawing.Size(1121, 612);
            this.Controls.Add(this.btnCargarEdicionCliente);
            this.Controls.Add(this.btnEliminarCliente);
            this.Controls.Add(this.btnActualizarCliente);
            this.Controls.Add(this.dataGridViewClientes);
            this.Controls.Add(this.btnAgregarCliente);
            this.Controls.Add(this.textBoxEmailCliente);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxTelefonoCliente);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxDireccionCliente);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxNombreCliente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "clientesForm";
            this.Text = "clientesForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNombreCliente;
        private System.Windows.Forms.TextBox textBoxDireccionCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTelefonoCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEmailCliente;
        private System.Windows.Forms.Label label5;
        private FontAwesome.Sharp.IconButton btnAgregarCliente;
        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private FontAwesome.Sharp.IconButton btnActualizarCliente;
        private FontAwesome.Sharp.IconButton btnCargarEdicionCliente;
        private FontAwesome.Sharp.IconButton btnEliminarCliente;
    }
}