using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis2.Models
{
    public class Usuario
    {
        [Key]
        public long id { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }
        public string rol { get; set; }

    }
}
