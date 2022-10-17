using MediatR;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.API.Common;

namespace RecipeBook.API.Controllers
{
    [ApiController]
    [Route(Constants.ApiTemplate)]
    public class BaseController : ControllerBase
    {
        private IMediator _mediator;
        protected IMediator Mediator => _mediator ??= HttpContext.RequestServices.GetService<IMediator>();

    }
}
