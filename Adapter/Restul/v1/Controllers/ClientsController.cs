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
    }
}