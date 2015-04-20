using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace Paquetes.Models
{
    public class FacturaPaquete
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string fecha { get; set; }
        public double total { get; set; }
        public int EnvioId { get; set; }
        public Envio Envio { get;set }
    }
}