using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CleanArchitecture.API.Presentation.Common.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ApiBaseController : ControllerBase
    {
        protected ISender Mediator;

        public ApiBaseController(ISender mediator)
        {
            Mediator = mediator;
        }
    }
}
