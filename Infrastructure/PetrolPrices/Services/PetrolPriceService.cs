using AutoMapper;
using Application.PetrolPrices.DTOs;
using Application.Services.PetrolPrices;
using CleanArchitecture.SharedLibrary.Common.DTOs;
using JamaicaOpenData.SharedLibrary.Common.DTOs;
using JamaicaOpenData.SharedLibrary.Common.Services;
using JoaPetrol = JamaicaOpenData.SharedLibrary.PetrolPrices.DTOs;

namespace Infrastructure.PetrolPrices.Services
{
    public class PetrolPriceService : IPetrolPriceService
    {
        private readonly IMapper _mapper;
        private readonly IJamaicaOpenDataService _jamaicaOpenDataService;

        public PetrolPriceService(IMapper mapper, IJamaicaOpenDataService jamaicaOpenDataService)
        {
            _mapper = mapper;
            _jamaicaOpenDataService = jamaicaOpenDataService;
        }

        public async Task<PaginatedList<PetrolPriceDto>> GetPetrolPrices(int limit, int pageNumber)
        {
            JoaResultDto<JoaPetrol.PetrolPriceDto> result = await _jamaicaOpenDataService.GetPetrolPrices(limit, pageNumber);
            var paginatedResult = _mapper.Map<PaginatedList<PetrolPriceDto>>(result);

            return paginatedResult;
        }
    }
}
