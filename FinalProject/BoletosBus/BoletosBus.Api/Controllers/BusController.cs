using BoletosBus.Api.Extension.BusExtension;
using BoletosBus.Api.Models.Bus;
using BoletosBus.Domain.Interfaces;
using BoletosBus.Infraestructure.Exceptions;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BoletosBus.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BusController : ControllerBase
    {
        private readonly IBusRepository _busRepository;

        public BusController(IBusRepository busRepository)
        {
            _busRepository = busRepository;
            
        }


        // GET: api/<BusController>
        [HttpGet("GetAllBus")]
        public async Task<IActionResult> GetAllBus()
        {
            try
            {
                var bus = await this._busRepository.GetAll();
                return Ok(bus);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving data.", details = ex.Message });
            }
        }

        // GET api/<BusController>/5
        [HttpGet("GetBusByID/{id}")]
        public async Task<IActionResult> GetBusById(int id)
        {
            try
            {
                var bus = await this._busRepository.GetById(id);

                if (bus is null)
                {
                    return NotFound(new { message = "Bus not found." });
                }

                return Ok(bus);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while retrieving data.", details = ex.Message });
            }
        }



        // POST api/<BusController>
        [HttpPost("CreateNewBus")]
        public async Task<IActionResult> CreateNewBus([FromBody] BusModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var bus = value.ToBus();
                await this._busRepository.Save(bus);
                return Ok(bus);
            }
            catch (BusException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while processing your request.", details = ex.Message });
            }

            
        }

        // PUT api/<BusController>/5
        [HttpPut("EditBus/{id}")]
        public async Task<IActionResult> EditBus(int id, [FromBody] BusModel value)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var existingBus = await _busRepository.GetById(id);
                if (existingBus == null)
                {
                    return NotFound(new { message = "Bus not found." });
                }

                var bus = value.ToBus();
                await this._busRepository.Update(bus);
                return Ok(bus);
            }
            catch (BusException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while updating the bus.", details = ex.Message });
            }
        }

        // DELETE api/<BusController>/5
        [HttpDelete("DeleteBus/{id}")]
        public async Task<IActionResult> DeleteBus(int id)
        {
            try
            {
                var existingBus = await _busRepository.GetById(id);
                if (existingBus is null)
                {
                    return NotFound(new { message = "Bus not found." });
                }

                await this._busRepository.Delete(id);
                return Ok();
            }
            catch (BusException ex)
            {
                return BadRequest(new { message = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { message = "An error occurred while deleting the bus.", details = ex.Message });
            }
        }
    }
}
