using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using InicioDeSesionWindowsFormsConTXT.Models;

namespace InicioDeSesionWindowsFormsConTXT
{
    public class FacturaManager
    {
        private string filePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\facturas.txt";

        public FacturaManager()
        {
            // Asegúrate de que el archivo existe al crear la instancia de FacturaManager
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close(); // Crea el archivo y luego ciérralo
            }
        }

        public void GuardarFactura(List<DetalleFactura> detallesFactura, decimal totalFactura)
        {
            int facturaId = ObtenerNuevoFacturaId();
            string fecha = DateTime.Now.ToString("yyyy-MM-dd");

            StringBuilder facturaData = new StringBuilder();
            facturaData.Append($"{facturaId},{fecha},");

            foreach (DetalleFactura detalle in detallesFactura)
            {
                facturaData.Append($"{detalle.Producto.Nombre},{detalle.Cantidad},{detalle.PrecioUnitario},{detalle.Subtotal},");
            }

            facturaData.AppendLine($"{totalFactura}"); // Añade el total de la factura y un salto de línea

            File.AppendAllText(filePath, facturaData.ToString()); // Guardar los datos en el archivo
        }

        private int ObtenerNuevoFacturaId()
        {
            var lastLine = File.ReadLines(filePath).LastOrDefault();
            if (lastLine != null)
            {
                int currentId = int.Parse(lastLine.Split(',')[0]);
                return currentId + 1;
            }
            return 1;
        }
    }

    public class DetalleFactura
    {
        public Producto1 Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal Subtotal { get; set; }
    }

    public class Producto1
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int CantidadStock { get; set; }
    }
}
