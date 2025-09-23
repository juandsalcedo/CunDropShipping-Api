using CunDropShipping.Api.Domain;


namespace CunDropShipping.Api.Application;

public interface IClientRepository_cs_
{
    List<DomainEntityClient> GetAll();
}