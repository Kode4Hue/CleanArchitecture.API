using Application.PetrolPrices.DTOs;
using CleanArchitecture.SharedLibrary.Common.DTOs;

namespace Application.Services.PetrolPrices
{
    public interface IPetrolPriceService
    {
        Task<PaginatedList<PetrolPriceDto>> GetPetrolPrices(int limit, int pageNumber);
    }
}
