using Api.Controllers.Core;
using Api.Models;
using BLL.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    public class UserController : BaseController<IUserService>
    {
        public UserController(IUserService service) : base(service)
        {
        }

        [HttpGet("GetAll")]
        public async Task<IEnumerable<BLL.DTO.User>> GetAll()
        {
            return await this._service.GetAll();
        }

        [HttpGet("GetByUsername")]
        public async Task<Entities.User> GetByUsername(string username) { return await this._service.GetEntityByUsername(username); }

        [HttpPost("Insert")]
        public async Task Insert(BLL.DTO.User user) { await this._service.Insert(user); }

        [HttpPut("Update")]
        public async Task Update(BLL.DTO.User user, string id) { await this._service.Update(user, id); }

        [HttpPost("Delete")]
        public async Task Delete(string id) { await this._service.Delete(id); }
    }
}
