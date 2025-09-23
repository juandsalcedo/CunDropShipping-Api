using CunDropShipping.Api.Domain;
using Microsoft.EntityFrameworkCore;

namespace CunDropShipping.Api.Infraestructure;

public class ClientDbContext  : DbContext
{
    public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
    {
        
    }
    public DbSet<DomainEntityClient> Clients { get; set; }
}