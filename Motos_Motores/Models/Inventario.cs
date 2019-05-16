using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Inventario
    {
        [Key]
        public int IdProducto { get; set; }
        public int Saldo { get; set; }



    }
}
