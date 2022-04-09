using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis2.Models.Response
{
    public class CreacionMaestrohistoria
    {
        
        public bool Validacion { get; set; }
        public string Mensaje { get; set; }

        public List<CuaadroMaestro> Maestro { get; set;}
       
    }
}
