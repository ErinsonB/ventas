using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Paquetes.Models
{
    public class Paquete
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public double peso { get; set; }
        [Required]
        public double alto{ get; set; }
        [Required]
        public double ancho { get; set; }
        [Required]
        public double largo { get; set; }
    }
}