using Api.Controllers.Core;
using Api.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class AuthenticationController : BaseController<IAuthenticationService>
    {
        public AuthenticationController(IAuthenticationService service) : base(service)
        {
        }

        [AllowAnonymous]
        [HttpPost("Login")]
        public async Task<AuthenticationResponse> Login([FromBody] AuthenticationRequest authRequest)
        {
            string jwtToken = await this._service.Login(authRequest.UserName, authRequest.Password);
            return new AuthenticationResponse() { JwtToken = jwtToken};
        }

        [HttpGet("AuthorizedPing")]
        public void AuthorizedPing()
        {
        }
    }
}
