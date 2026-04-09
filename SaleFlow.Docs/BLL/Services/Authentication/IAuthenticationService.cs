using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public interface IAuthenticationService
    {
        public Task<string> Login(string username, string password);
        public Task Logout(string jwtToken);
    }
}
