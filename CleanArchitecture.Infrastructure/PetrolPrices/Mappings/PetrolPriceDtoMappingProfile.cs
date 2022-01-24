using AutoMapper;
using CleanArchitecture.Application.PetrolPrices.DTOs;
using Joa = JamaicaOpenData.SharedLibrary.PetrolPrices.DTOs;

namespace CleanArchitecture.Infrastructure.PetrolPrices.Mappings
{
    public class PetrolPriceDtoMappingProfile:Profile
    {

        public PetrolPriceDtoMappingProfile()
        {
            CreateMap<Joa.PetrolPriceDto, OutletDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.OutletId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.OutletName));
            CreateMap<Joa.PetrolPriceDto, PetrolPriceDto>(); 
        }
    }
}
