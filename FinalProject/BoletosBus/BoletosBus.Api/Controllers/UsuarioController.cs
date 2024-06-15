using BoletosBus.Domain.Interfaces;
using Microsoft.AspNetCore.Mvc;
using BoletosBus.Api.Models.Usuario;
using BoletosBus.Api.Extension.UsuarioExtension;
using BoletosBus.Infraestructure.Exceptions;

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
            try
            {
                var usuario = this._usuarioRepository.GetAllUsuario();
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving data.", details = ex.Message });
            }

            
            
        }



        // GET api/<UsuarioController>/5
        
        [HttpGet("GetUsuarioById/{id}")]
        public async Task<IActionResult> GetUsuarioById(int id)
        {
            try
            {
                var usuario = await this._usuarioRepository.GetById(id);
                if (usuario is null)
                {
                    return NotFound(new { message = "Bus not found." });
                }
                return Ok(usuario);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving data.", details = ex.Message });
            }

            

            
        }

        // POST api/<UsuarioController>
        [HttpPost("CreateNewUsuario")]
        public async Task<IActionResult> CreateNewUsuario([FromBody] UsuarioSaveModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var usuarios = value.ToUsuario();
                await this._usuarioRepository.Save(usuarios);

                return Ok();

            }
            catch (UsuarioException ex)
            {

                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex) 
            {
                return StatusCode(500, new { message = "An error occurred while creating the bus.", details = ex.Message });
            }

            
        }

        // PUT api/<UsuarioController>/5
        [HttpPut("EditUsuario/{id}")]
        public async Task<IActionResult> EditUsuario(int id, [FromBody] UsuarioUpdateModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var existingUsuario = await this._usuarioRepository.GetById(id);
                if (existingUsuario is null)
                {
                    return NotFound(new { message = "User not found." });
                }

                var usuario = value.ToUsuario();
                await this._usuarioRepository.Update(usuario);
                return Ok();
            }
            catch (UsuarioException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { message = "An error occurred while updating the bus.", details = ex.Message });
            }

            
        }

        // DELETE api/<UsuarioController>/5
        [HttpDelete("DeleteUsuario/{id}")]
        public async Task<IActionResult> DeleteUsuario(int id)
        {
            try
            {
                var existingUsuario = await this._usuarioRepository.GetById(id);
                if (existingUsuario is null)
                {
                    return NotFound(new { message = "User not found." });
                }

                await this._usuarioRepository.Delete(id);
                return Ok("Usuario Eliminado");
            }
            catch (UsuarioException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {

                return StatusCode(500, new { message = "An error occurred while updating the bus.", details = ex.Message });
            }

        }
    }
}
