using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InicioDeSesionWindowsFormsConTXT.Models;

namespace InicioDeSesionWindowsFormsConTXT
{
    public partial class UsuariosForm : Form
    {
        private GestorDeUsuarios gestorDeUsuarios;

        public UsuariosForm(GestorDeUsuarios gestor)
        {
            InitializeComponent();
            gestorDeUsuarios = gestor;
            CargarUsuarios();
        }
        // Método para cargar usuarios en el DataGridView
        private void CargarUsuarios()
        {
            var usuarios = gestorDeUsuarios.ObtenerUsuarios();
            dataGridViewUsuarios.DataSource = usuarios.Select(u => new
            {
                u.Nombre,
                u.Apellido,
                u.NombreUsuario,
                u.Contrasena,
                u.Telefono
            }).ToList();
        }
        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados por el usuario
            string nombre = textBoxNombre.Text;
            string apellido = textBoxApellido.Text;
            string nombreUsuario = textBoxUsuario.Text;
            string contrasena = textBoxPassword.Text;
            string telefono = textBoxTelefono.Text;

            // Validación de campos vacíos
            if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(apellido) ||
                string.IsNullOrEmpty(nombreUsuario) || string.IsNullOrEmpty(contrasena) ||
                string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("Todos los campos son obligatorios.");
                return;
            }

            try
            {
                // Crear un nuevo usuario
                Usuario nuevoUsuario = new Usuario(nombre, apellido, nombreUsuario, contrasena, telefono);

                // Registrar el usuario utilizando GestorDeUsuarios
                gestorDeUsuarios.RegistrarUsuario(nuevoUsuario);

                MessageBox.Show("Usuario registrado exitosamente.");

                // Limpiar los TextBox después de guardar
                textBoxNombre.Clear();
                textBoxApellido.Clear();
                textBoxUsuario.Clear();
                textBoxPassword.Clear();
                textBoxTelefono.Clear();

                // Recargar los usuarios en el DataGridView
                CargarUsuarios();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el usuario: {ex.Message}");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsuarios.SelectedRows.Count > 0)
            {
                // Obtiene el nombre de usuario seleccionado
                string nombreUsuario = dataGridViewUsuarios.SelectedRows[0].Cells["NombreUsuario"].Value.ToString();

                // Elimina el usuario utilizando GestorDeUsuarios
                gestorDeUsuarios.EliminarUsuario(nombreUsuario);

                MessageBox.Show("Usuario eliminado exitosamente.");

                // Recargar los usuarios en el DataGridView
                CargarUsuarios();
            }
            else
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
            }
        }
    }
}
