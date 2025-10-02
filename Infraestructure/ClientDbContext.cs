using CunDropShipping.Api.Domain;
using CunDropShipping.Api.Infraestructure.Entity;
using Microsoft.EntityFrameworkCore;

namespace CunDropShipping.Api.Infraestructure;

public class ClientDbContext  : DbContext
{
    public ClientDbContext(DbContextOptions<ClientDbContext> options) : base(options)
    {
        
    }
    public DbSet<Client> Clients { get; set; }
}