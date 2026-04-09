using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public interface IUserService
    {
        public Task<IEnumerable<BLL.DTO.User>> GetAll();
        public Task<BLL.DTO.User> GetById(string id);

        public Task<Entities.User> GetEntityByUsername(string username);

        public Task Insert(BLL.DTO.User user);
        public Task Update(BLL.DTO.User user, string id);
        public Task Delete( string id);
    }
}
