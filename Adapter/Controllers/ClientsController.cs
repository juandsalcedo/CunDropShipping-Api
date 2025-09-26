using CunDropShipping.Api.Application;
using CunDropShipping.Api.Application.DTOs;

namespace CunDropShipping.Api.Adapter.Controllers;
using CunDropShipping.Api.Domain;   
using Microsoft.AspNetCore.Mvc;

[ApiController] 
[Route("api/v1/clients")] 


public class ClientsController: ControllerBase
{
    private readonly IClientService _clientService;

    public ClientsController(IClientService clientService)
    {
        _clientService = clientService;
    }

    [HttpGet]
    public ActionResult<List<ClientDto>> GetAllClients()
    {
        var clients = _clientService.GetAllClients();
        return Ok(clients);
    }
}