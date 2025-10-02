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
    }
}

// C 1.1.0...JDST 

