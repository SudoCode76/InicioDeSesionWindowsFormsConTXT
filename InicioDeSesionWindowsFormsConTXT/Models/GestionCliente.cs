using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioDeSesionWindowsFormsConTXT.Models
{
    public class GestionCliente
    {
        private string filePath = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\clientes.txt";  // Asegúrate de que el archivo exista o maneja la creación.

        public List<Cliente> CargarClientes()
        {
            List<Cliente> clientes = new List<Cliente>();
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    clientes.Add(new Cliente()
                    {
                        Nombre = data[0],
                        Direccion = data[1],
                        Telefono = data[2],
                        Email = data[3]
                    });
                }
            }
            return clientes;
        }

        public void AgregarCliente(string nombre, string direccion, string telefono, string email)
        {
            string nuevaLinea = $"{nombre},{direccion},{telefono},{email}";
            using (StreamWriter sw = File.AppendText(filePath))
            {
                sw.WriteLine(nuevaLinea);
            }
        }

        public void EliminarCliente(string nombre)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            var lineToRemove = lines.FirstOrDefault(line => line.StartsWith(nombre + ","));
            if (lineToRemove != null)
            {
                lines.Remove(lineToRemove);
                File.WriteAllLines(filePath, lines);
            }
        }

        public void ActualizarCliente(string nombreOriginal, string nombre, string direccion, string telefono, string email)
        {
            List<string> lines = File.ReadAllLines(filePath).ToList();
            var index = lines.FindIndex(line => line.StartsWith(nombreOriginal + ","));
            if (index != -1)
            {
                lines[index] = $"{nombre},{direccion},{telefono},{email}";
                File.WriteAllLines(filePath, lines);
            }
        }
    }
}
