using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis2.Models
{
    public class Creacionderegistros
    {
        [Key]
        public long id { get; set; }
        public string Sede { get; set; }
        public string Division { get; set; }
        public string Facultad { get; set; }
        public string Nombredeprograma { get; set; }
        public string Registrounico { get; set; }
        public string Numerodecreditos { get; set; }
        public string Modalidad { get; set; }
        public string EncargadodeUCDF { get; set; }


    }
}
