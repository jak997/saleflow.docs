using Api.Controllers.Core;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class QuoteController : BaseController<IQuoteService>
    {
        public QuoteController(IQuoteService service) : base(service)
        {
        }


        [HttpPost("Create")]
        public void Create() //todo 
        {
        }
    }
}
