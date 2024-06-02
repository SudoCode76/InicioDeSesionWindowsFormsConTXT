using System; // Importa el espacio de nombres System que proporciona clases fundamentales y tipos base.
using System.Collections.Generic; // Importa las clases relacionadas con colecciones genéricas.
using System.Linq; // Importa clases para consultas con LINQ.
using System.Text; // Importa clases para trabajar con texto.
using System.Threading.Tasks; // Importa clases relacionadas con tareas asincrónicas.

namespace InicioDeSesionWindowsFormsConTXT.Models // Define un espacio de nombres para organizar el código.
{
    public class Categoria // Declara una clase pública llamada 'Categoria'.
    {
        // Propiedad pública de tipo string para almacenar el nombre de la categoría.
        public string Nombre { get; set; }

        // Propiedad pública de tipo lista de productos para almacenar los productos de la categoría.
        public List<Producto> Productos { get; set; }

        // Constructor de la clase 'Categoria'.
        public Categoria()
        {
            // Inicializa la lista de productos cuando se crea una nueva instancia de 'Categoria'.
            Productos = new List<Producto>();
        }
    }
}
