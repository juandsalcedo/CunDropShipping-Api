using CunDropShipping.Api.Application.DTOs;

using CunDropShipping.Api.Domain;

namespace CunDropShipping.Api.Application;

public interface IInfraestructureMapper
{
    List<ClientDto> ToClientDtos(List<DomainEntityClient> clients);
}