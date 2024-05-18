using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioDeSesionWindowsFormsConTXT.Models
{
    // Clase que representa a un usuario
    public class Usuario
    {
        // Propiedades del usuario
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasena { get; set; }
        public string Telefono { get; set; }

        // Constructor que inicializa todas las propiedades del usuario
        public Usuario(string nombre, string apellido, string nombreUsuario, string contrasena, string telefono)
        {
            Nombre = nombre;
            Apellido = apellido;
            NombreUsuario = nombreUsuario;
            Contrasena = contrasena;
            Telefono = telefono;
        }
    }
}
