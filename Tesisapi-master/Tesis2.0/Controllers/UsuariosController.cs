using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Tesis2.Models;
using Tesis2.Models.Response;
using Tesis2.Context;


namespace Tesis2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuariosController : ControllerBase
    {
        private readonly AppDbContext context;
        public UsuariosController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public IActionResult PostValidacionUsuario(Usuario Usuriosadmon)
        {
            RespuestaUsuario Valit = new RespuestaUsuario();
            try
            {
                var listUsurio = context.Usuarios.ToList();
                foreach(var vp in listUsurio)
                {
                    if ((vp.Correo == Usuriosadmon.Correo) && (vp.Contrasena == Usuriosadmon.Contrasena))
                    {
                        if (vp.rol == "Docente")
                        {
                            Valit.Mensaje = "Correcto";
                            Valit.TipodeRolAutenticado = "Docente";
                            Valit.Validacion = true;
                            return Ok(Valit);
                        }
                      
                       


                    }
                    else
                    {
                        Valit.Mensaje = "Invalido";
                        Valit.TipodeRolAutenticado = "Sin identificar";
                        Valit.Validacion = false;
                    }
                }
                return Ok(Valit);
              

                

            }
            catch (Exception e)
            {

                Valit.Mensaje = e.Message;



            }
            return Ok(Valit);
        }
    }
}
