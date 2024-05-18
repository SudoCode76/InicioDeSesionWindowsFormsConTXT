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
    public partial class Registrar : Form
    {
        private GestorDeUsuarios gestorDeUsuarios;

        public Registrar(GestorDeUsuarios gestor)
        {
            InitializeComponent();
            gestorDeUsuarios = gestor;
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados por el usuario
            string nombre = textBoxRNombre.Text;
            string apellido = textBoxRApellido.Text;
            string nombreUsuario = textBoxRUsuario.Text;
            string contrasena = textBoxRContraseña.Text;
            string telefono = textBoxRPhone.Text;

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

                Form1 form1 = new Form1();
                this.Hide();
                form1.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocurrió un error al registrar el usuario: {ex.Message}");
            }
        

        }
    }
}
