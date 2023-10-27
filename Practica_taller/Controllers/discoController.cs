using Microsoft.AspNetCore.Mvc;
using Practica_taller.context;
using Practica_taller.Modelos;

namespace Practica_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class discoController : ControllerBase
    {

        private readonly ILogger<discoController> _logger;
        private readonly aplicacion_Context _aplicacion_Context;
        public discoController(
            ILogger<discoController> logger,
            aplicacion_Context aplicacion_Context)
        {
            _logger = logger;
            _aplicacion_Context = aplicacion_Context;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Disco Disco)
        {
            _aplicacion_Context.Disco.Add(Disco);
            _aplicacion_Context.SaveChanges();
            return Ok(Disco);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacion_Context.Disco.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Disco Disco)
        {
            _aplicacion_Context.Disco.Update(Disco);
            _aplicacion_Context.SaveChanges();
            return Ok(Disco);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int ID_disco)
        {
            _aplicacion_Context.Disco.Remove(
                _aplicacion_Context.Disco.ToList()
                .Where(x => x.id_disco == ID_disco)
                .FirstOrDefault());
            _aplicacion_Context.SaveChanges();
            return Ok(ID_disco);
        }
    }
}

