using CunDropShipping.Api.Application.DTOs;
using CunDropShipping.Api.Domain;
using CunDropShipping.Api.Infraestructure;
using CunDropShipping.Api.Infraestructure.Mapper;

namespace CunDropShipping.Api.Application.Service
{
    public class ClientServiceImp : IClientService
    {
        private readonly Repository _repository;
        private readonly IInfraestructureMapper _mapper;

        
        public ClientServiceImp(Repository repository, IInfraestructureMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<DomainEntityClient> GetAllClients()
        {
            return _repository.GetAll();
        }
        public void UpdateClientFullName(int id, string newFullName)
        {
            // Busca el cliente usando la nueva herramienta del repositorio.
            var clientToUpdate = _repository.GetById(id);

            // Si lo encontramos, continuamos con la lógica.
            if (clientToUpdate != null)
            {
                //Usamos el método del Dominio para aplicar la regla de negocio (cambiar el nombre).
                clientToUpdate.ChangeFullName(newFullName);
                
                // El repository guarda las actualizaciones en la base de datos.
                _repository.SaveChanges();
            }
           
        }
    }
}

// C 1.1.0...JDST 

