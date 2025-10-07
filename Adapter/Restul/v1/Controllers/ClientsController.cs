using CunDropShipping.Api.Application;
using CunDropShipping.Api.Application.DTOs;
using CunDropShipping.Api.Domain;
using Microsoft.AspNetCore.Mvc;

namespace CunDropShipping.Api.Adapter.Restul.v1.Controllers
{
    [ApiController] 
    [Route("api/v1/clients")] 
    public class ClientsController: ControllerBase
    {
        private readonly IClientService _clientService;
        //llamar al mapper

        public ClientsController(IClientService clientService)
        {
            _clientService = clientService;
        }

        [HttpGet]
        public ActionResult<List<AdapterClientDto>> GetAllClients()
        {
            var clients = _clientService.GetAllClients();
            return Ok(clients);
        }
        
        [HttpPatch("{id}/fullname")]
        public IActionResult UpdateFullName(int id, [FromBody] string newFullName)
        {
            try
            {
                _clientService.UpdateClientFullName(id, newFullName);
                return Ok($"El nombre del cliente con ID {id} fue actualizado correctamente.");
            }
            catch (Exception ex)
            {
                // Si el nombre está vacío, devolvemos un error claro.
                return BadRequest(ex.Message);
            }
        }
    }
}