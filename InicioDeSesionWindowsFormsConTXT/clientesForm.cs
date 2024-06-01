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
    public partial class clientesForm : Form
    {
        GestionCliente gestionCliente = new GestionCliente();

        public clientesForm()
        {
            InitializeComponent();
            dataGridViewClientes.DataSource = gestionCliente.CargarClientes();

        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            string nombre = textBoxNombreCliente.Text;
            string direccion = textBoxDireccionCliente.Text;
            string telefono = textBoxTelefonoCliente.Text;
            string email = textBoxEmailCliente.Text;

            // Instancia de la clase de gestión de clientes
            GestionCliente gestionCliente = new GestionCliente();
            gestionCliente.AgregarCliente(nombre, direccion, telefono, email);

            // Limpia los campos
            textBoxNombreCliente.Clear();
            textBoxDireccionCliente.Clear();
            textBoxTelefonoCliente.Clear();
            textBoxEmailCliente.Clear();

            // Recargar el DataGridView
            dataGridViewClientes.DataSource = gestionCliente.CargarClientes();

        }

        private void btnCargarEdicionCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null)
            {
                textBoxNombreCliente.Text = dataGridViewClientes.CurrentRow.Cells["Nombre"].Value.ToString();
                textBoxDireccionCliente.Text = dataGridViewClientes.CurrentRow.Cells["Direccion"].Value.ToString();
                textBoxTelefonoCliente.Text = dataGridViewClientes.CurrentRow.Cells["Telefono"].Value.ToString();
                textBoxEmailCliente.Text = dataGridViewClientes.CurrentRow.Cells["Email"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente para editar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnActualizarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null)
            {
                string nombreOriginal = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString(); // Asumiendo que el nombre está en la primera columna
                string nombre = textBoxNombreCliente.Text;
                string direccion = textBoxDireccionCliente.Text;
                string telefono = textBoxTelefonoCliente.Text;
                string email = textBoxEmailCliente.Text;

                GestionCliente gestionCliente = new GestionCliente();
                gestionCliente.ActualizarCliente(nombreOriginal, nombre, direccion, telefono, email);

                // Limpia los campos y recarga los datos
                textBoxNombreCliente.Clear();
                textBoxDireccionCliente.Clear();
                textBoxTelefonoCliente.Clear();
                textBoxEmailCliente.Clear();
                dataGridViewClientes.DataSource = gestionCliente.CargarClientes();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado ningún cliente para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            if (dataGridViewClientes.CurrentRow != null)
            {
                string nombre = dataGridViewClientes.CurrentRow.Cells[0].Value.ToString(); // Asumiendo que el nombre está en la primera columna

                GestionCliente gestionCliente = new GestionCliente();
                gestionCliente.EliminarCliente(nombre);

                // Recargar el DataGridView
                dataGridViewClientes.DataSource = gestionCliente.CargarClientes();
            }
            else
            {
                MessageBox.Show("Por favor seleccione un cliente para eliminar.", "Selección Requerida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
