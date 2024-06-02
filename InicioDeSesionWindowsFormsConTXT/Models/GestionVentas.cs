using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioDeSesionWindowsFormsConTXT.Models
{
    public class GestionVentas
    {
        private string pathVentas = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\RegistroVentas.txt";

        public void GuardarCompra(DataGridView dataGridViewClientes, DataGridView dataGridViewDetalleFactura)
        {
            if (dataGridViewClientes == null || dataGridViewClientes.CurrentRow == null)
            {
                MessageBox.Show("No hay cliente seleccionado o dataGridViewClientes no está inicializado.");
                return;
            }
            if (dataGridViewDetalleFactura == null || dataGridViewDetalleFactura.Rows == null)
            {
                MessageBox.Show("dataGridViewDetalleFactura no está inicializado o no tiene filas.");
                return;
            }

            using (StreamWriter sw = File.AppendText(pathVentas))
            {
                sw.WriteLine($"Fecha: {DateTime.Now}");
                string cliente = dataGridViewClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                sw.WriteLine($"Cliente: {cliente}");

                foreach (DataGridViewRow row in dataGridViewDetalleFactura.Rows)
                {
                    if (row.Cells[0].Value == null || row.Cells[1].Value == null || row.Cells[2].Value == null)
                    {
                        MessageBox.Show("Una o más celdas están vacías.");
                        continue;
                    }
                    string producto = row.Cells[0].Value.ToString();
                    int cantidad = Convert.ToInt32(row.Cells[1].Value);
                    decimal precioUnitario = Convert.ToDecimal(row.Cells[2].Value);
                    decimal total = Convert.ToDecimal(row.Cells[3].Value);
                    sw.WriteLine($"Producto: {producto}, Cantidad: {cantidad}, Precio Unitario: {precioUnitario}, Total: {total}");
                }
                sw.WriteLine("--------------------------------------------------");
            }
        }
    }
}
