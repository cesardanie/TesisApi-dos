using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tesis2.Models;
using Tesis2.Models.Response;
using Tesis2.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Tesis2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuadroMaestroController : ControllerBase
    {
        private readonly AppDbContext context;
        public CuadroMaestroController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetCreacionMaestro()
        {
            Respuesta Ret = new Respuesta();
            CreacionMaestrohistoria create=new CreacionMaestrohistoria();
            try
            {
                
                var lst = context.CuaadroMaestros.ToList();
                create.Validacion = true;
                create.Maestro = lst;
                create.Mensaje = "correcto";
            }catch(Exception ex)
            {
                create.Mensaje = ex.Message;

                
            }
            return Ok(create);
        }
    }
}
