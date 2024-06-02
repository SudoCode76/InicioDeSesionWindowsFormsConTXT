using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioDeSesionWindowsFormsConTXT.Models
{
    public class ProductoCategoria
    {
        public string CategoriaNombre { get; set; }
        public string ProductoNombre { get; set; }
        public string ProductoDescripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }
}
