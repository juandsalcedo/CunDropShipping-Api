using CunDropShipping.Api.Application.DTOs;
using CunDropShipping.Api.Domain;

namespace CunDropShipping.Api.Adapter.Restul.v1.Controllers.Mapper;

public interface IAdapterMapper
{
   AdapterClientDto toAdapterClientDto(DomainEntityClient domainEntity);
   
   DomainEntityClient toDomainEntityDto(AdapterClientDto adapterClientDto);
   
   List<DomainEntityClient> toDomainEntityDtoList(List<AdapterClientDto> adapterClientDtoList);
   
   List<AdapterClientDto> toAdapterClientDtoList(List<DomainEntityClient> domainEntityList);
   
}