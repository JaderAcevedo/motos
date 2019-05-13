using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Producto
    {

        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del producto es requerido")]
        [Display(Name = "Nombre del Producto")]
        [MaxLength(50)]
        public string NombreProducto { get; set; }

        [Required(ErrorMessage = "La Descripcion es requerido")]
        [Display(Name = "Descripcion Del Producto")]
        [MaxLength(50)]
        public string Descripcion { get; set; }

        [ForeignKey("Proveedor")]
        [Display(Name = "Proveedor")]
        public int IdProveedor { get; set; }
        [Display(Name = "Proveedor")]
        public Proveedor Proveedor { get; set; }

        [Required(ErrorMessage = "El Costo Del Producto es requerido")]
        [Display(Name = "Costo Del Producto")]
        public int CostoProducto { get; set; }

       
    }
}
