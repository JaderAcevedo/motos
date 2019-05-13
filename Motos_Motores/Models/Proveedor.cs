using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Proveedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre de la empresa es requerido")]
        [Display(Name = "Nombre de la empresa")]
        [MaxLength(50)]
        public string NombreEmpresa { get; set; }

        [Required(ErrorMessage = "El nombre del vendedor es requerido")]
        [Display(Name = "Nombre del vendedor")]
        [MaxLength(50)]
        public string NombreVendedor { get; set; }

        [Required(ErrorMessage = "El email es requerido")]
        [Display(Name = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        public ICollection<Producto> Producto { get; set; }



    }
}
