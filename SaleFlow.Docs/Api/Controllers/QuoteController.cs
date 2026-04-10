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
        public async Task Create(BLL.DTO.Quote quote) //todo 
        {
             await this._service.Create(quote);
        }

        [HttpPost("AuthorizedPostTest")]
        public void AuthorizedPostTest() //todo 
        {
        }
    }
}
