using CunDropShipping.Api.Domain;
using CunDropShipping.Api.Application.DTOs;

namespace CunDropShipping.Api.Application;

public interface  IClientService
{
    List<DomainEntityClient> GetAllClients();
   
}