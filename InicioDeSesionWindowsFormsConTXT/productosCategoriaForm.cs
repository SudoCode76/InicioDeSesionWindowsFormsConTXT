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
    public partial class productosCategoriaForm : Form
    {
        GestionCategoria gestionCategoria = new GestionCategoria();
        ProductoManager productoManager = new ProductoManager();


        public productosCategoriaForm()
        {
            InitializeComponent();
            gestionCategoria.CargarCategorias();
            productoManager.CargarProductos();
            CargarProductosPorCategoria();
        }

        private void productosCategoriaForm_Load(object sender, EventArgs e)
        {

        }
        private void CargarProductosPorCategoria()
        {
            List<ProductoCategoria> productosCategorias = new List<ProductoCategoria>();
            var categorias = gestionCategoria.CargarCategoriasConProductos();  // Asume que este método devuelve categorías con sus productos

            foreach (var categoria in categorias)
            {
                foreach (var producto in categoria.Productos)
                {
                    productosCategorias.Add(new ProductoCategoria
                    {
                        CategoriaNombre = categoria.Nombre,
                        ProductoNombre = producto.Nombre,
                        ProductoDescripcion = producto.Descripcion,
                        Precio = producto.Precio,
                        Stock = producto.CantidadStock
                    });
                }
            }

            dataGridViewProductos.DataSource = productosCategorias;
            ConfigurarColumnasProductosPorCategoria();
        }

        private void ConfigurarColumnasProductosPorCategoria()
        {
            // Ajusta las columnas según tus necesidades
            dataGridViewProductos.Columns["CategoriaNombre"].HeaderText = "Categoría";
            dataGridViewProductos.Columns["ProductoNombre"].HeaderText = "Producto";
            dataGridViewProductos.Columns["ProductoDescripcion"].HeaderText = "Descripcion";
            dataGridViewProductos.Columns["Precio"].HeaderText = "Precio";
            dataGridViewProductos.Columns["Stock"].HeaderText = "CantidadStock";

            dataGridViewProductos.AutoResizeColumns();
        }

        
    }
}
