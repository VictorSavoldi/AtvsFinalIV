using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using webapicarros.Persistence;
using webapicarros.Models;
using Microsoft.EntityFrameworkCore;

namespace webapicarros.Controllers
{
    [ApiController]
    [Route("v1/carros")]
    public class CarroController : ControllerBase
    {

        [HttpGet]
        [Route("")]
        public async Task<ActionResult<List<Carro>>> Get([FromServices] Context context)
        {
            var carros = await context.Carros.ToListAsync();

            return Ok(carros);
        }


        [HttpPost]
        [Route("")]
        public async Task<ActionResult<Carro>> Post([FromServices] Context context, [FromBody] Carro carro)
        {
            if (ModelState.IsValid)
            {
                context.Carros.Add(carro);
                await context.SaveChangesAsync();

                return carro;
            }
            else
                return BadRequest(ModelState);
        }
    }
}