using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Inventario
    {
        public int Id { get; set; }
        public int IdProducto { get; set; }

        public int Cantidad { get; set; }

    }
}
