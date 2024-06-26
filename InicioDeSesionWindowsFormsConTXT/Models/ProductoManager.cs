﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InicioDeSesionWindowsFormsConTXT.Models
{
    public class ProductoManager
    {
        string filePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\productos.txt";

        public List<Producto> CargarProductos()
        {
            List<Producto> productos = new List<Producto>();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    productos.Add(new Producto()
                    {
                        Nombre = data[0],
                        Descripcion = data[1],
                        Precio = Convert.ToDecimal(data[2]),
                        CantidadStock = Convert.ToInt32(data[3])
                    });
                }
            }
            return productos;
        }

        public void AgregarProducto(string nombre, string descripcion, decimal precio, int stock)
        {
            string nuevaLinea = $"{nombre},{descripcion},{precio},{stock}";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(nuevaLinea);
            }
        }


        public void EliminarProducto(string nombre)
        {
            // Leer todos los productos
            List<string> lines = File.ReadAllLines(filePath).ToList();

            // Encuentra el producto a eliminar
            var lineToRemove = lines.FirstOrDefault(line => line.StartsWith(nombre + ","));

            if (lineToRemove != null)
            {
                // Elimina el producto
                lines.Remove(lineToRemove);

                // Guarda la lista modificada de vuelta al archivo
                File.WriteAllLines(filePath, lines);
            }
        }

        public void ActualizarProducto(string nombreOriginal, string nombre, string descripcion, decimal precio, int stock)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            var index = lines.FindIndex(line => line.StartsWith(nombreOriginal + ","));
            if (index != -1)
            {
                lines[index] = $"{nombre},{descripcion},{precio},{stock}";
                File.WriteAllLines(filePath, lines);
            }
        }

        public void ActualizarStockProducto(string nombreProducto, int cantidadComprada)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            int index = lines.FindIndex(line => line.StartsWith(nombreProducto + ","));

            if (index != -1)
            {
                var data = lines[index].Split(',');
                int stockActual = Convert.ToInt32(data[3]); // Asumiendo que el stock es el cuarto elemento
                int nuevoStock = stockActual - cantidadComprada;

                if (nuevoStock < 0)
                {
                    throw new InvalidOperationException("No hay suficiente stock para realizar la venta.");
                }

                // Construir la nueva línea con el stock actualizado
                string nuevaLinea = $"{data[0]},{data[1]},{data[2]},{nuevoStock}";
                lines[index] = nuevaLinea;

                // Guardar las modificaciones de vuelta al archivo
                File.WriteAllLines(filePath, lines);
            }
            else
            {
                throw new ArgumentException("Producto no encontrado");
            }
        }




    }
}
