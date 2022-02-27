using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Presentation.Common.Controllers
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
