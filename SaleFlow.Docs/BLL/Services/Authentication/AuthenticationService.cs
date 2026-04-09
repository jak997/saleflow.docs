using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using BLL.Services.Core;
using Microsoft.IdentityModel.Tokens;

namespace BLL.Services
{
    public class AuthenticationService : EnvironmentBaseService, IAuthenticationService
    {
        private IUserService _userService;
        public AuthenticationService(Configuration config, IUserService service) : base(config) 
        {
            _userService = service;
        }

        public async Task<string> Login(string username, string password)
        {
            Console.Write("service.login");
            Entities.User user = await _userService.GetEntityByUsername(username);

            if (user == null || !this.PasswordChecker(password, user.Password))
            {
                throw new Exception("Username or password not found");
            }
            return this.GenerateToken(username, "test_role");
        }

        public Task Logout(string jwtToken)
        {
            //todo blackList Via Redis
            throw new NotImplementedException();
        }

        #region Utils 
        private string GenerateToken(string username, string role) 
        {   
            return "test";
        }

        private bool PasswordChecker(string inputPassword, string password)
        {
            return String.Compare(inputPassword, password, StringComparison.Ordinal) == 0;
        }
        #endregion
    }
}