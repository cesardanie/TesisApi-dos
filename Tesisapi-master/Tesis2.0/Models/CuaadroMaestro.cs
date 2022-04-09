using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis2.Models
{
    public class CuaadroMaestro
    {
        [Key]
        public long id { get; set; }
        public string Denominacion { get; set; }
        public string Sede { get; set; }
        public string ResolucionMen { get; set; }
        public string Vencimiento { get; set; }
        
        public string Lugar { get; set; }
        public string SNIES { get; set; }

        public string Modalidad { get; set; }
        public string Niveldeformacion { get; set; }
        public string Proceso { get; set; }
        public string Estado { get; set; }
    }
}
