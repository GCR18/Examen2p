using Microsoft.AspNetCore.Mvc;
using Practica_taller.context;
using Practica_taller.Modelos;

namespace Practica_taller.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class musicaContoller : ControllerBase
    {

        private readonly ILogger<musicaContoller> _logger;
        private readonly aplicacion_Context _aplicacion_Context;
        public musicaContoller(
            ILogger<musicaContoller> logger,
            aplicacion_Context aplicacion_Context)
        {
            _logger = logger;
            _aplicacion_Context = aplicacion_Context;
        }
        [Route("")]
        [HttpPost]
        public IActionResult Post(
            [FromBody] Musica Musica)
        {
            _aplicacion_Context.Musica.Add(Musica);
            _aplicacion_Context.SaveChanges();
            return Ok(Musica);
        }
        [Route("")]
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_aplicacion_Context.Musica.ToList());

        }
        [Route("{id}")]
        [HttpPut]
        public IActionResult Put(
            [FromBody] Musica Musica)
        {
            _aplicacion_Context.Musica.Update(Musica);
            _aplicacion_Context.SaveChanges();
            return Ok(Musica);
        }
        [Route("{id}")]
        [HttpDelete]
        public IActionResult Delete(int ID_musica)
        {
            _aplicacion_Context.Musica.Remove(
                _aplicacion_Context.Musica.ToList()
                .Where(x => x.id_musica == ID_musica)
                .FirstOrDefault());
            _aplicacion_Context.SaveChanges();
            return Ok(ID_musica);
        }
    }
}
