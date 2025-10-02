using CunDropShipping.Api.Domain;


namespace CunDropShipping.Api.Application;

public interface IClientRepository
{
    List<DomainEntityClient> GetAll();
}