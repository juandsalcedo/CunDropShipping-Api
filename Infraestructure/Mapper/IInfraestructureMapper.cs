using CunDropShipping.Api.Domain;
using CunDropShipping.Api.Infraestructure.Entity;

namespace CunDropShipping.Api.Infraestructure.Mapper;

public interface IInfraestructureMapper
{
    DomainEntityClient ToDomainClientDto(Client client);
    List<DomainEntityClient> ToDomainClientDtos(List<Client> clients);

    Client toInfraestructureClientDto(DomainEntityClient domainEntity);
    List<Client> toInfraestructureClientDtoList(List<DomainEntityClient> domainEntityList);
    
}