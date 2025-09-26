using CunDropShipping.Api.Application;
using CunDropShipping.Api.Application;
using CunDropShipping.Api.Application.DTOs;

using CunDropShipping.Api.Domain;

namespace CunDropShipping.Api.Infraestructure;

public class InfrastructureMapperImp : IInfraestructureMapper
{
    public List<ClientDto> ToClientDtos(List<DomainEntityClient> clients)
    {
        // La misma lógica de traducción que vimos, pero ahora en su propia clase.
        return clients.Select(entity => new ClientDto
        {
            Id = entity.Id,
            FullName = $"{entity.FirstName} {entity.LastName}",
            Email = entity.Email,
            Phone = entity.Phone
        }).ToList();
    }
}