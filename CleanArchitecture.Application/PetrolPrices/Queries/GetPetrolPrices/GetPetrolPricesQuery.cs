using CleanArchitecture.Application.PetrolPrices.DTOs;
using CleanArchitecture.SharedLibrary.Common.DTOs;
using MediatR;

namespace CleanArchitecture.Application.PetrolPrices.Queries.GetPetrolPrices
{
    public class GetPetrolPricesQuery: IRequest<PaginatedList<PetrolPriceDto>>
    {
        public int Limit { get; set; }
        public int PageNumber { get; set; }
    }
}
    