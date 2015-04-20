using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Paquetes.Models
{
    public class Rol
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string nombreRol { get; set; }
    }
}