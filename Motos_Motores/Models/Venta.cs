using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Venta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La Fecha es requerido")]
        [Display(Name = "Fecha De La Venta")]
        [MaxLength(50)]
        public DateTime Fecha { get; set; }

        [Required(ErrorMessage = "El nombre del Cliente es requerido")]
        [Display(Name = "Nombre del Cliente")]
        [MaxLength(50)]
        public String Cliente { get; set; }

        [Required(ErrorMessage = "El nombre del Producto es requerido")]
        [Display(Name = "Nombre del Producto")]
        [MaxLength(50)]
        public String Producto { get; set; }

        [Required(ErrorMessage = "La cantidad es requerido")]
        [Display(Name = "Cantidad")]
        [MaxLength(50)]
        public String Cantidad { get; set; }

        [Required(ErrorMessage = "el total es requerido")]
        [Display(Name = "Total")]
        public int Total { get; set; }
    }
}
