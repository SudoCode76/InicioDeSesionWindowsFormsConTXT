using InicioDeSesionWindowsFormsConTXT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioDeSesionWindowsFormsConTXT
{
    public partial class productoForm : Form
    {
        ProductoManager productoManager = new ProductoManager();

        public productoForm()
        {
            InitializeComponent();
            dataGridViewProductos.DataSource = productoManager.CargarProductos();
        }

        private void btnGuardarProducto_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombre.Text;
            string descripcion = textBoxDescripcion.Text;
            decimal precio = decimal.Parse(textBoxPrecio.Text); // Considerar TryParse para manejo de errores
            int stock = int.Parse(textBoxStock.Text); // Considerar TryParse para manejo de errores

            productoManager.AgregarProducto(nombre, descripcion, precio, stock);

            // Limpia los campos después de guardar
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();
            textBoxStock.Clear();
            dataGridViewProductos.DataSource = productoManager.CargarProductos();

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                string nombre = dataGridViewProductos.CurrentRow.Cells[0].Value.ToString(); // Asume que el nombre está en la primera columna
                productoManager.EliminarProducto(nombre);

                // Actualiza el DataGridView
                dataGridViewProductos.DataSource = productoManager.CargarProductos();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCargarEdicion_Click(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null)
            {
                textBoxNombre.Text = dataGridViewProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                textBoxDescripcion.Text = dataGridViewProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                textBoxPrecio.Text = dataGridViewProductos.CurrentRow.Cells["Precio"].Value.ToString();
                textBoxStock.Text = dataGridViewProductos.CurrentRow.Cells["CantidadStock"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un producto para editar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

      

        private void btnActualizar_Click_1(object sender, EventArgs e)
        {
            string nombreOriginal = dataGridViewProductos.CurrentRow.Cells[0].Value.ToString();
            string nombre = textBoxNombre.Text;
            string descripcion = textBoxDescripcion.Text;
            decimal precio = decimal.Parse(textBoxPrecio.Text); // Considerar TryParse para manejo de errores
            int stock = int.Parse(textBoxStock.Text); // Considerar TryParse para manejo de errores

            productoManager.ActualizarProducto(nombreOriginal, nombre, descripcion, precio, stock);

            // Limpia los campos después de actualizar y recarga los datos
            textBoxNombre.Clear();
            textBoxDescripcion.Clear();
            textBoxPrecio.Clear();
            textBoxStock.Clear();
            dataGridViewProductos.DataSource = productoManager.CargarProductos();

        }
    }
}
