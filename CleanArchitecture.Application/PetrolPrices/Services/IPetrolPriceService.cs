using CleanArchitecture.Application.PetrolPrices.DTOs;
using CleanArchitecture.SharedLibrary.Common.DTOs;

namespace CleanArchitecture.Application.Services.PetrolPrices
{
    public interface IPetrolPriceService
    {
        Task<PaginatedList<PetrolPriceDto>> GetPetrolPrices(int limit, int pageNumber);
    }
}
