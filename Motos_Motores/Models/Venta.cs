using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La Fecha es requerido")]
        [Display(Name = "Fecha De La Venta")]
        public DateTime Fecha { get; set; }

        [ForeignKey("Cliente")]
        [Required(ErrorMessage = "El nombre del Cliente es requerido")]
        [Display(Name = "Nombre del Cliente")]
         public int IdCliente { get; set; }
        public Cliente Cliente { get; set; }

        [ForeignKey("Producto")]
        [Required(ErrorMessage = "El nombre del Producto es requerido")]
        [Display(Name = "Nombre del Producto")]
        public int IdProducto { get; set; }
        public Producto Producto { get; set; }

        [Required(ErrorMessage = "La cantidad es requerido")]
        [Display(Name = "Cantidad")]
        public int Cantidad { get; set; }

        [Required(ErrorMessage = "el total es requerido")]
        [Display(Name = "Total")]
        public int Total { get; set; }
    }
}
