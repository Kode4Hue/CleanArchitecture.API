﻿using CleanArchitecture.API.Presentation.Common.Controllers;
using CleanArchitecture.Application.PetrolPrices.Queries.GetPetrolPrices;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using CleanArchitecture.Application.PetrolPrices.DTOs;
using CleanArchitecture.SharedLibrary.Common.DTOs;

namespace CleanArchitecture.API.Presentation.PetrolPrices.Controllers
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