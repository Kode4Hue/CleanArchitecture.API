using AutoMapper;
using CleanArchitecture.Application.PetrolPrices.DTOs;
using CleanArchitecture.SharedLibrary.Common.DTOs;
using JoaCommon = JamaicaOpenData.SharedLibrary.Common.DTOs;
using JoaPetrol = JamaicaOpenData.SharedLibrary.PetrolPrices.DTOs;

namespace CleanArchitecture.Infrastructure.PetrolPrices.Mappings
{
    public class PetrolPriceDtoMappingProfile:Profile
    {

        public PetrolPriceDtoMappingProfile()
        {
            CreateMap<JoaPetrol.PetrolPriceDto, OutletDto>()
                .ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.OutletId))
                .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.OutletName));
            CreateMap<JoaPetrol.PetrolPriceDto, PetrolPriceDto>()
                .ForMember(dest => dest.Outlet, opt => opt.MapFrom(src => src));

            CreateMap<JoaCommon.JoaResultDto<JoaPetrol.PetrolPriceDto>, PaginatedList<PetrolPriceDto>>()
            .ForMember(dest => dest.Items, opt => opt.MapFrom(src => src.Records))
            .ForMember(dest => dest.TotalCount, opt => opt.MapFrom(src => src.Total))
            .ForMember(dest => dest.ItemsPerPage, opt => opt.MapFrom(src => src.Limit))
            .ForMember(dest => dest.TotalPages, opt => opt.MapFrom(src => src.Total / src.Limit))
            .ForMember(dest => dest.CurrentPageNumber, opt => opt.Ignore());

        }
    }
}
