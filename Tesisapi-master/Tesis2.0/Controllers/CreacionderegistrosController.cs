using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Tesis2.Context;
using Tesis2.Models;
using Tesis2.Models.Response;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;


namespace Tesis2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CreacionderegistrosController : ControllerBase
    {
        private readonly AppDbContext context;
        public CreacionderegistrosController(AppDbContext context)
        {
            this.context = context;
        }
        [HttpPost]
        public IActionResult PostCreacionRegistro(Creacionderegistros Creacion)
        {
            RespuestaRegistro res = new RespuestaRegistro();
            try
            {
                res.Validacion = true;
                res.Mensaje = "Con exito";
                context.Creacionderegistros.Add(Creacion);
                context.SaveChanges();
                return Ok(res);


            }catch(Exception ex)
            {
                res.Mensaje = ex.Message;
            }
            return Ok(res);
        }
       [HttpGet]
       public async Task<IActionResult> Getoptenerultimoregistro()
        {
            RespuestaRegistroPagedos Resp = new RespuestaRegistroPagedos();
            Creacionderegistros Restlist = new Creacionderegistros();
            
            
            try {

                var lst = context.Creacionderegistros.OrderByDescending(p => p.id).ToList();
                Resp.Registros = lst;
                Resp.Mensaje = "Exito";

            }catch(Exception e)
            {
                Resp.Mensaje = e.Message;   
            }
            return Ok(Resp);
        }

    }
}
