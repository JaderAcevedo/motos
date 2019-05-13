using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Venta
    {
        public int Id { get; set; }

        public DateTime Fecha { get; set; }

        public String Cliente { get; set; }

        public String Producto { get; set; }

        public String Cantidad { get; set; }

        public int Total { get; set; }
    }
}
