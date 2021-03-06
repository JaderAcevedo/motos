﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Compra
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La Fecha es requerido")]
        [Display(Name = "Fecha De La Compra")]
        public DateTime Fecha { get; set; }
        
        [ForeignKey("Producto")]
        [Display(Name = "Producto")]
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }
        public int Cantidad { get; set; }

    }
}
