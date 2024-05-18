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
    public partial class Dashboard : Form
    {
        private GestorDeUsuarios gestorDeUsuarios;
        private const string RUTA_ARCHIVO = @"C:\Users\migue\OneDrive - Universidad Privada Domingo Savio\PROYECTOS\InicioDeSesionWindowsFormsConTXT\InicioDeSesionWindowsFormsConTXT\usuarios.txt";

        public Dashboard()
        {
            InitializeComponent();
            gestorDeUsuarios = new GestorDeUsuarios(RUTA_ARCHIVO); // Crear una instancia de GestorDeUsuarios

        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            panelDashboard.Controls.Clear();
            UsuariosForm usuariosForm = new UsuariosForm(gestorDeUsuarios);
            usuariosForm.TopLevel = false;
            usuariosForm.Dock = DockStyle.Fill;
            panelDashboard.Controls.Add(usuariosForm);
            usuariosForm.Show();
        }
    }
}
