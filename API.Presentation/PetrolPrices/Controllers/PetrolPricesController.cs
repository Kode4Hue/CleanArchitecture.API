using API.Presentation.Common.Controllers;
using Application.PetrolPrices.DTOs;
using Application.PetrolPrices.Queries.GetPetrolPrices;
using CleanArchitecture.SharedLibrary.Common.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Presentation.PetrolPrices.Controllers
{
    public class PetrolPricesController : ApiBaseController
    {
        public PetrolPricesController(ISender mediator) : base(mediator)
        {
        }

        [HttpGet]
        public async Task<ActionResult<PaginatedList<PetrolPriceDto>>> GetPetrolPrices(
            [FromQuery] GetPetrolPricesQuery query)
        {
            return await Mediator.Send(query);
        }
    }
}
