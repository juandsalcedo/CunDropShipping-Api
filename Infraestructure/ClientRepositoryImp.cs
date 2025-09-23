using CunDropShipping.Api.Application;
using CunDropShipping.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace CunDropShipping.Api.Infraestructure;

public class ClientRepositoryImp : IClientRepository_cs_
{
    private readonly ClientDbContext _context;

    public ClientRepositoryImp(ClientDbContext context)
    {
        _context = context;
    }

    
    public List<DomainEntityClient> GetAll()
    {
        return _context.Clients.ToList();
    }
}