using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaxiKiosco.Models
{
    public class Categoria
    {
        public int CategoriaID { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Boolean Estado { get; set; }
        public int Precio { get; set; }
        public int Cantidad { get; set; }

    }
}
