using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Paquetes.Models
{
    public class Bodega
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string nombreBodega { get; set; }
        [Required]
        public int espacioBodega { get; set; }
        [Required]
        public string direccionBodega { get; set; }
    }
}