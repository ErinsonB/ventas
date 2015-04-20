using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Paquetes.Models
{
    public class Transporte
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string nombreTransporte { get; set; }
        [Required]
        public string matricula { get; set; }
    }
}