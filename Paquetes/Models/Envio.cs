using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Paquetes.Models
{
    public class Envio
    {
        [Key]
        public int ID { get; set; }

        public int UsuarioId { get; set; }
        public string lugarEnvio { get; set; }
        public int PaqueteId { get; set; }
        public int cantidad { get; set; }
        public int BodegaId { get; set; }
        public string lugarRecibe { get; set; }
        public int TransporteId { get; set; }

        public Usuario Usuario { get; set; }
        public Paquete Paquete { get; set; }
        public Bodega Bodega { get; set; }
        public Transporte Transporte { get; set; }

        

    }
}