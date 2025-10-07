using CunDropShipping.Api.Domain;


namespace CunDropShipping.Api.Application;

public interface IClientRepository
{
    List<DomainEntityClient> GetAll();
    DomainEntityClient GetById(int id);
    void SaveChanges();
}