using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioDeSesionWindowsFormsConTXT.Models
{
    public class GestionCategoria
    {
        private string filePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\categorias.txt";
        private string filePathCategorias = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\categorias.txt";

        private string filePathProductos = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\categoriaProductos.txt";

        public List<Categoria> CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            var productoLines = File.ReadAllLines(filePathProductos).ToList();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var categoria = new Categoria { Nombre = line };
                    categoria.Productos = productoLines
                        .Where(p => p.StartsWith(categoria.Nombre + ","))
                        .Select(p => new Producto { Nombre = p.Split(',')[1] }) // Asegúrate que los datos de productos estén correctamente formateados
                        .ToList();
                    categorias.Add(categoria);
                }
            }
            return categorias;
        }

        public void AgregarCategoria(string nombre)
        {
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(nombre);
            }
        }

        

        public void ActualizarCategoria(string nombreOriginal, string nuevoNombre)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            var index = lines.FindIndex(line => line.Equals(nombreOriginal));
            if (index != -1)
            {
                lines[index] = nuevoNombre;
                File.WriteAllLines(filePath, lines);
            }
        }

        public void AgregarProductoACategoria(string nombreCategoria, Producto producto)
        {
            // Comprobación de que el archivo existe y está accesible.
            if (!File.Exists(filePathProductos))
            {
                // Crear el archivo si no existe
                using (var sw = File.CreateText(filePathProductos)) { }
            }

            // Agregar la entrada de producto en el formato: nombreCategoria,nombreProducto,descripcion,precio,stock
            using (StreamWriter sw = File.AppendText(filePathProductos))
            {
                sw.WriteLine($"{nombreCategoria},{producto.Nombre},{producto.Descripcion},{producto.Precio},{producto.CantidadStock}");
            }
        }


        public List<Categoria> CargarCategoriasConProductos()
        {
            // Cargar todas las categorías
            List<Categoria> categorias = new List<Categoria>();
            if (File.Exists(filePathCategorias))
            {
                string[] categoriasData = File.ReadAllLines(filePathCategorias);
                foreach (string lineaCategoria in categoriasData)
                {
                    Categoria categoria = new Categoria
                    {
                        Nombre = lineaCategoria,
                        Productos = new List<Producto>()
                    };
                    categorias.Add(categoria);
                }
            }

            // Cargar todos los productos y asociarlos con sus categorías
            if (File.Exists(filePathProductos))
            {
                string[] productosData = File.ReadAllLines(filePathProductos);
                foreach (string lineaProducto in productosData)
                {
                    string[] partes = lineaProducto.Split(',');
                    if (partes.Length >= 5) // Asegúrate de que la línea tiene suficientes partes para formar un producto
                    {
                        string nombreCategoria = partes[0];
                        Producto producto = new Producto
                        {
                            Nombre = partes[1],
                            Descripcion = partes[2],
                            Precio = Convert.ToDecimal(partes[3]),
                            CantidadStock = Convert.ToInt32(partes[4])
                        };

                        Categoria categoria = categorias.FirstOrDefault(c => c.Nombre == nombreCategoria);
                        if (categoria != null)
                        {
                            categoria.Productos.Add(producto);
                        }
                    }
                }
            }

            return categorias;
        }

        public void EliminarCategoria(string nombre)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            var lineToRemove = lines.FirstOrDefault(line => line.Equals(nombre));
            if (lineToRemove != null)
            {
                lines.Remove(lineToRemove);
                File.WriteAllLines(filePath, lines);
            }
        }

        

    }
}
