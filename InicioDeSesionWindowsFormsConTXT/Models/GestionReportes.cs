using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace InicioDeSesionWindowsFormsConTXT.Models
{
    public class GestionReportes
    {
        private string ventasFilePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\RegistroVentas.txt";
        private string productosFilePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\Productos.txt";
        private string clientesFilePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\clientes.txt";

        public GestionReportes()
        {
            EnsureFileExists(ventasFilePath);
            EnsureFileExists(productosFilePath);
            EnsureFileExists(clientesFilePath);
        }

        private void EnsureFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                File.Create(filePath).Close();
            }
        }

        public List<Venta> GenerarReporteVentas(DateTime fechaInicio, DateTime fechaFin)
        {
            var ventas = new List<Venta>();
            var registros = File.ReadAllLines(ventasFilePath);

            foreach (var registro in registros)
            {
                if (!registro.StartsWith("Fecha: ")) continue;

                var fecha = DateTime.Parse(registro.Substring("Fecha: ".Length).Trim());
                if (fecha < fechaInicio || fecha > fechaFin) continue;

                var cliente = registros.SkipWhile(line => !line.StartsWith("Cliente: ")).First().Substring("Cliente: ".Length).Trim();
                var producto = registros.SkipWhile(line => !line.StartsWith("Producto: ")).First().Substring("Producto: ".Length).Split(',')[0].Trim();
                var cantidad = int.Parse(registros.SkipWhile(line => !line.Contains("Cantidad: ")).First().Split(',')[1].Split(':')[1].Trim());
                var precioUnitario = decimal.Parse(registros.SkipWhile(line => !line.Contains("Precio Unitario: ")).First().Split(',')[2].Split(':')[1].Trim());
                var total = decimal.Parse(registros.SkipWhile(line => !line.Contains("Total: ")).First().Split(',')[3].Split(':')[1].Trim());

                ventas.Add(new Venta
                {
                    Fecha = fecha,
                    Cliente = cliente,
                    Producto = producto,
                    Cantidad = cantidad,
                    PrecioUnitario = precioUnitario,
                    Total = total
                });
            }

            return ventas;
        }

        public List<LineaReporte> LeerArchivoCompleto()
        {
            var contenido = new List<LineaReporte>();
            var lineas = File.ReadAllLines(ventasFilePath);

            LineaReporte reporte = null;
            foreach (var linea in lineas)
            {
                if (linea.StartsWith("Fecha: "))
                {
                    reporte = new LineaReporte();
                    reporte.Fecha = linea.Substring("Fecha: ".Length).Trim();
                }
                else if (linea.StartsWith("Cliente: "))
                {
                    reporte.Cliente = linea.Substring("Cliente: ".Length).Trim();
                }
                else if (linea.StartsWith("Producto: "))
                {
                    var partes = linea.Substring("Producto: ".Length).Split(',');
                    reporte.Producto = partes[0].Trim();
                    reporte.Cantidad = int.Parse(partes[1].Split(':')[1].Trim());
                    reporte.PrecioUnitario = decimal.Parse(partes[2].Split(':')[1].Trim());
                    reporte.Total = decimal.Parse(partes[3].Split(':')[1].Trim());
                    contenido.Add(reporte); // Añade el reporte completo a la lista
                }
            }

            return contenido;
        }





    }
}
