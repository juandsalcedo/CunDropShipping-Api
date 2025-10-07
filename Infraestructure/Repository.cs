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

    public DomainEntityClient GetById(int id)
    {
        //  Buscamos el cliente en la base de datos. Esto nos da una entidad de tipo 'Client'.
        var clientFromDb = _context.Clients.Find(id);

        // Si no lo encontramos, es importante manejarlo (en este caso, devolvemos null).
        if (clientFromDb == null)
        {
            return null;
        }

        /*Usamos el mapper para TRADUCIR el 'Client' de la base de datos
        a un 'DomainEntityClient' que nuestra aplicación entiende.*/
        
        return _mapper.ToDomainClientDto(clientFromDb);
    }

    public void SaveChanges()
    {
        _context.SaveChanges();
    }
}