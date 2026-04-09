using BLL.Services.Core;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers.Core
{
    [ApiController]
    [Route("Api/[controller]")]
    [Authorize]
    public abstract class BaseController<TService> : ControllerBase
    {
        protected readonly TService _service;
        protected BaseController(TService service)
        {
            _service = service;
        }
    }
}