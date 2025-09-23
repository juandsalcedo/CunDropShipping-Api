using CunDropShipping.Api.Application.DTOs;

namespace CunDropShipping.Api.Application.Service
{
    public class ClientServiceImp : IClientService
    {
        private readonly IClientRepository_cs_ _repository;
        private readonly IInfraestructureMapper _mapper;

        // ¡Recibe el repositorio Y el mapper, igual que el profesor!
        public ClientServiceImp(IClientRepository_cs_ repository, IInfraestructureMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public List<ClientDto> GetAllClients()
        {
            // 1. Llama al repositorio para obtener los datos crudos
            var clientEntities = _repository.GetAll();

            // 2. Usa el mapper para traducir los datos y los devuelve
            return _mapper.ToClientDtos(clientEntities);
        }
    }
}