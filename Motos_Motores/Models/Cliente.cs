using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Motos_Motores.Models
{
    public class Cliente
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        [Display(Name = "Nombre del Cliente")]
        [MaxLength(50)]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage = "El Apellido del cliente es requerido")]
        [Display(Name = "Apellido del Cliente")]
        [MaxLength(50)]
        public string ApellidoCliente { get; set; }

        [Required(ErrorMessage = "El Sexo del cliente es requerido")]
        [Display(Name = "Sexo del Cliente")]
        [MaxLength(50)]
        public string Sexo { get; set; }

        [Required(ErrorMessage = "La Direccion del cliente es requerido")]
        [Display(Name = "Direccion del Cliente")]
        [MaxLength(50)]
        public string Direccion { get; set; }

        [Required(ErrorMessage = "El teléfono es requerido")]
        [Display(Name = "Teléfono")]
        [DataType(DataType.PhoneNumber)]
        public string Telefono { get; set; }

        public ICollection<Venta> ventas { get; set; }

    }
}
