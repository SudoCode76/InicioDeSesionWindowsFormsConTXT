using InicioDeSesionWindowsFormsConTXT.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InicioDeSesionWindowsFormsConTXT
{
    public partial class Form1 : Form
    {
        private GestorDeUsuarios gestorDeUsuarios;
        private const string RUTA_ARCHIVO = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\InicioDeSesionWindowsFormsConTXT\usuarios.txt";

        public Form1()
        {
            InitializeComponent();
            gestorDeUsuarios = new GestorDeUsuarios(RUTA_ARCHIVO);

        }

        private void buttonIniciarSesion_Click(object sender, EventArgs e)
        {
            // Obtiene los valores ingresados por el usuario
            string nombreUsuario = textBoxUsuario.Text;
            string contrasena = textBoxContraseña.Text;

            // Valida las credenciales del usuario utilizando el gestor de usuarios
            if (gestorDeUsuarios.ValidarUsuario(nombreUsuario, contrasena))
            {
                // Abriendo formulario Dashboard
                Dashboard dashboard = new Dashboard();
                this.Hide();
                dashboard.Show();
            }
            else
            {
                // Muestra un mensaje de error si las credenciales son incorrectas
                MessageBox.Show("Nombre de usuario o contraseña incorrectos");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Registrar registrar = new Registrar(gestorDeUsuarios);
            this.Hide();
            registrar.Show();
        }
    }
}
