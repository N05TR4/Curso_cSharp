using BoletosBus.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BoletosBus.Api.Models.Usuario;
using BoletosBus.Api.Extension.UsuarioExtension;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletosBus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsuarioController : ControllerBase
    {
        private readonly IUsuarioRepository _usuarioRepository;
        public UsuarioController(IUsuarioRepository usuarioRepository)
        {
            this._usuarioRepository = usuarioRepository;
        }


        // GET: api/<UsuarioController>

        
        [HttpGet("GetAllUsuario")]
        public IActionResult GetAllUsuario()
        {
            var usuario = this._usuarioRepository.GetAllUsuario();
            return Ok(usuario);
        }



        // GET api/<UsuarioController>/5
        
        [HttpGet("GetUsuarioById/{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            var usuario = await this._usuarioRepository.GetById(id);

            return Ok(usuario);
        }

        // POST api/<UsuarioController>
        [HttpPost("CreateNewUsuario")]
        public async Task<IActionResult> CreateNewUsuario([FromBody] List<UsuarioSaveModel> value)
        {
           var usuarios = value.Select(v => v.ToUsuario()).ToList();
            await this._usuarioRepository.Save(usuarios);

            return Ok();
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("EditUsuario/{id}")]
        public async Task<IActionResult> EditUsuario(int id, [FromBody] UsuarioUpdateModel value)
        {
            var usuario = value.ToUsuario();
            await this._usuarioRepository.Update(usuario);
            return Ok();
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("DeleteUsuario/{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            await this._usuarioRepository.Delete(id);
            return Ok("Usuario Eliminado");
        }
    }
}
