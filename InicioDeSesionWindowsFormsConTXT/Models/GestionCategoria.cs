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
        private string filePath = @"Data\categorias.txt";

        public List<Categoria> CargarCategorias()
        {
            List<Categoria> categorias = new List<Categoria>();
            if (File.Exists(filePath))
            {
                var lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    categorias.Add(new Categoria { Nombre = data[0] });
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
    }
}
