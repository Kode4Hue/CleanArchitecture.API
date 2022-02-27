using Application.PetrolPrices.DTOs;
using Application.Services.PetrolPrices;
using CleanArchitecture.SharedLibrary.Common.DTOs;
using MediatR;

namespace Application.PetrolPrices.Queries.GetPetrolPrices
{
    public class GetPetrolPricesQueryHandler : IRequestHandler<GetPetrolPricesQuery, PaginatedList<PetrolPriceDto>>
    {
        private readonly IPetrolPriceService _petrolPriceService;

        public GetPetrolPricesQueryHandler(IPetrolPriceService petrolPriceService)
        {
            _petrolPriceService = petrolPriceService;
        }

        public async Task<PaginatedList<PetrolPriceDto>> Handle(GetPetrolPricesQuery request, CancellationToken cancellationToken)
        {
            return await _petrolPriceService.GetPetrolPrices(request.Limit, request.PageNumber);
        }
    }
}
