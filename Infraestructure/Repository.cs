using CunDropShipping.Api.Application;
using CunDropShipping.Api.Domain;
using CunDropShipping.Api.Infraestructure.Mapper;
using Microsoft.EntityFrameworkCore;

namespace CunDropShipping.Api.Infraestructure;

public class Repository : IClientRepository
{
    private readonly ClientDbContext _context;
    private readonly IInfraestructureMapper _mapper;

    public Repository(ClientDbContext context,  IInfraestructureMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    
    public List<DomainEntityClient> GetAll()
    {
        return _mapper.ToDomainClientDtos(_context.Clients.AsNoTracking().OrderBy(client => client.ClientId).ToList());
    }
}