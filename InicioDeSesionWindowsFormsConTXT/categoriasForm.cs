using InicioDeSesionWindowsFormsConTXT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioDeSesionWindowsFormsConTXT;


namespace InicioDeSesionWindowsFormsConTXT
{
    public partial class categoriasForm : Form
    {
        GestionCategoria gestionCategoria = new GestionCategoria();
        ProductoManager productoManager = new ProductoManager();
        public event EventHandler productosPorCategoria;

        public categoriasForm()
        {
            InitializeComponent();
            dataGridViewCategorias.DataSource = gestionCategoria.CargarCategorias();
            dataGridViewProductos.DataSource = productoManager.CargarProductos();
            gestionCategoria.CargarCategorias();
            productoManager.CargarProductos();


        }

        



        private void btnAgregarCategoria_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreCategoria.Text;
            gestionCategoria.AgregarCategoria(nombre);
            dataGridViewCategorias.DataSource = gestionCategoria.CargarCategorias();
            textBoxNombreCategoria.Clear();

        }

        private void btnCargarEdicionCategoria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.CurrentRow != null)
            {
                textBoxNombreCategoria.Text = dataGridViewCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
            }
        }

        private void btnActualizarCategoria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.CurrentRow != null)
            {
                string nombreOriginal = dataGridViewCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
                string nuevoNombre = textBoxNombreCategoria.Text;
                gestionCategoria.ActualizarCategoria(nombreOriginal, nuevoNombre);
                dataGridViewCategorias.DataSource = gestionCategoria.CargarCategorias();
                textBoxNombreCategoria.Clear();
            }
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.CurrentRow != null)
            {
                string nombre = dataGridViewCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
                gestionCategoria.EliminarCategoria(nombre);
                dataGridViewCategorias.DataSource = gestionCategoria.CargarCategorias();
            }
        }



        private void btnAsociarProductoACategoria_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategorias.CurrentRow != null && dataGridViewProductos.CurrentRow != null)
            {
                string nombreCategoria = dataGridViewCategorias.CurrentRow.Cells["Nombre"].Value.ToString();
                string nombreProducto = dataGridViewProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                string descripcion = dataGridViewProductos.CurrentRow.Cells["Descripcion"].Value.ToString();
                decimal precio = Convert.ToDecimal(dataGridViewProductos.CurrentRow.Cells["Precio"].Value);
                int stock = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells["CantidadStock"].Value);

                // Asume que producto y categoria tienen propiedades como nombre
                GestionCategoria gestionCategoria = new GestionCategoria();
                Producto producto = new Producto
                {
                    Nombre = nombreProducto,
                    Descripcion = descripcion,
                    Precio = precio,
                    CantidadStock = stock
                };

                gestionCategoria.AgregarProductoACategoria(nombreCategoria, producto);

                MessageBox.Show($"Producto {nombreProducto} asociado a la categoría {nombreCategoria}.", "Asociación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Seleccione tanto una categoría como un producto.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            productosPorCategoria?.Invoke(this, EventArgs.Empty);
        }
    }
}
