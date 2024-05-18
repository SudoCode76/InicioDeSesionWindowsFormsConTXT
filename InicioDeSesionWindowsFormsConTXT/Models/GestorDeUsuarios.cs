using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioDeSesionWindowsFormsConTXT.Models
{

    // Clase que gestiona la carga y validación de usuarios desde un archivo de texto
    public class GestorDeUsuarios
    {
        // Lista de usuarios cargados desde el archivo
        private List<Usuario> usuarios;
        private string rutaArchivo;

        // Constructor que recibe la ruta del archivo y carga los usuarios
        public GestorDeUsuarios(string rutaArchivo)
        {
            this.rutaArchivo = rutaArchivo;
            usuarios = new List<Usuario>();
            CargarUsuarios(rutaArchivo);
        }

        // Método que carga los usuarios desde el archivo especificado
        private void CargarUsuarios(string rutaArchivo)
        {
            // Verifica si el archivo existe
            if (File.Exists(rutaArchivo))
            {
                // Lee todas las líneas del archivo
                var lineas = File.ReadAllLines(rutaArchivo);
                foreach (var linea in lineas)
                {
                    // Divide cada línea en nombre, apellido, nombre de usuario, contraseña y teléfono
                    var datos = linea.Split(',');
                    if (datos.Length == 5)
                    {
                        // Añade un nuevo usuario a la lista
                        usuarios.Add(new Usuario(datos[0], datos[1], datos[2], datos[3], datos[4]));
                    }
                }
            }
            else
            {
                // Lanza una excepción si el archivo no existe
                throw new FileNotFoundException("El archivo de usuarios no existe.");
            }
        }

        // Método que obtiene la lista de usuarios
        public List<Usuario> ObtenerUsuarios()
        {
            return usuarios;
        }

        // Método que valida si el nombre de usuario y la contraseña son correctos
        public bool ValidarUsuario(string nombreUsuario, string contrasena)
        {
            // Recorre la lista de usuarios para encontrar una coincidencia
            foreach (var usuario in usuarios)
            {
                if (usuario.NombreUsuario == nombreUsuario && usuario.Contrasena == contrasena)
                {
                    return true; // Retorna true si encuentra una coincidencia
                }
            }
            return false; // Retorna false si no encuentra coincidencias
        }

        // Método que registra un nuevo usuario en el archivo de usuarios
        public void RegistrarUsuario(Usuario nuevoUsuario)
        {
            // Crear la línea a guardar en el archivo
            string nuevaLinea = $"{nuevoUsuario.Nombre},{nuevoUsuario.Apellido},{nuevoUsuario.NombreUsuario},{nuevoUsuario.Contrasena},{nuevoUsuario.Telefono}";

            // Añadir la nueva línea al archivo de usuarios
            File.AppendAllText(rutaArchivo, nuevaLinea + Environment.NewLine);
            usuarios.Add(nuevoUsuario); // Añadir el usuario a la lista interna
        }

        // Método que elimina un usuario del archivo y la lista interna
        public void EliminarUsuario(string nombreUsuario)
        {
            // Encuentra el usuario a eliminar
            var usuarioAEliminar = usuarios.FirstOrDefault(u => u.NombreUsuario == nombreUsuario);
            if (usuarioAEliminar != null)
            {
                usuarios.Remove(usuarioAEliminar); // Remueve el usuario de la lista interna
                // Actualizar el archivo de texto
                File.WriteAllLines(rutaArchivo, usuarios.Select(u => $"{u.Nombre},{u.Apellido},{u.NombreUsuario},{u.Contrasena},{u.Telefono}"));
            }
        }
    }
}
