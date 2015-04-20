using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Paquetes.Models
{
    public class Usuario
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string nombreUsuario { get; set; }
        [Required]
        public string nickUsuario { get; set; }
        [Required]
        public string contrasenia { get; set; }

        public int RolId { get; set; }
        public Rol Rol { get; set; }
    }
}