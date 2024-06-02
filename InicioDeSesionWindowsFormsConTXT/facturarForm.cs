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

namespace InicioDeSesionWindowsFormsConTXT
{
    public partial class facturarForm : Form
    {
        GestionCliente gestionCliente = new GestionCliente();
        ProductoManager productoManager = new ProductoManager();
        GestionVentas gestionVentas = new GestionVentas();


        public facturarForm()
        {
            InitializeComponent();
            dataGridViewClientes.DataSource = gestionCliente.CargarClientes(); // Asume una clase gestorClientes que carga los clientes
            dataGridViewProductos.DataSource = productoManager.CargarProductos(); // Asume una clase gestorProductos que carga los productos

            dataGridViewDetalleFactura.Columns.Add("NombreProducto", "Producto");
            dataGridViewDetalleFactura.Columns.Add("Cantidad", "Cantidad");
            dataGridViewDetalleFactura.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridViewDetalleFactura.Columns.Add("Total", "Total");
        }




        private void btnAgregarProductoAFactura_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProductos.CurrentRow != null && numericCantidad.Value > 0)
            {
                string nombreProducto = dataGridViewProductos.CurrentRow.Cells["Nombre"].Value.ToString();
                decimal precio = Convert.ToDecimal(dataGridViewProductos.CurrentRow.Cells["Precio"].Value);
                int cantidad = Convert.ToInt32(numericCantidad.Value);

                ProductoManager productoManager = new ProductoManager();

                try
                {
                    // Intenta actualizar el stock del producto
                    productoManager.ActualizarStockProducto(nombreProducto, cantidad);

                    // Agregar fila al DataGridView de detalle de factura
                    DataGridViewRow newRow = new DataGridViewRow();
                    newRow.CreateCells(dataGridViewDetalleFactura);
                    newRow.Cells[0].Value = nombreProducto;
                    newRow.Cells[1].Value = cantidad;
                    newRow.Cells[2].Value = precio;
                    newRow.Cells[3].Value = precio * cantidad;
                    dataGridViewDetalleFactura.Rows.Add(newRow);

                    // Opcional: Actualizar la visualización de DataGridViewProductos
                    dataGridViewProductos.CurrentRow.Cells["CantidadStock"].Value = Convert.ToInt32(dataGridViewProductos.CurrentRow.Cells["CantidadStock"].Value) - cantidad;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error al actualizar el stock", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un producto y asegúrese de que la cantidad sea mayor a cero.", "Información Faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnFinalizarCompra_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null && dataGridViewDetalleFactura.Rows.Count > 0)
            {
                // Guarda la compra en el archivo de registro
                gestionVentas.GuardarCompra(dataGridViewClientes, dataGridViewDetalleFactura);

                MessageBox.Show("Compra finalizada y registrada exitosamente.", "Compra Completa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridViewDetalleFactura.Rows.Clear();
                numericCantidad.Value = 1;
            }
            else
            {
                MessageBox.Show("Seleccione un cliente y añada productos a la factura.", "Información Faltante", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}
