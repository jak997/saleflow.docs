using BLL.DTO;
using BLL.Repositories;
using BLL.Services.Core;
using Entities;
using System.Collections;
using System.Linq.Expressions;

namespace BLL.Services
{
    public class UserService : ConnectedBaseService<IUserRepository>, IUserService
    {
        public UserService(Configuration config, IUserRepository repository) : base(config, repository) { }

        public async Task<IEnumerable<DTO.User>> GetAll()
        {
            IEnumerable<Entities.User> users = await this._repository.GetAllAsync();

            return users.Select(u => new DTO.User()
            {
                Id = u.Id,
                Username = u.Username,
                FirstName = u.FirstName,
                LastName = u.LastName,
            });
        }

        public async Task<DTO.User> GetById(string id)
        {
            DTO.User retValue = new();
            Entities.User dbUser = await this._repository.GetByIdAsync(id);

            if (dbUser == null)
            {
                throw new ArgumentException(id);
            }
            else
            {
                retValue = new()
                {
                    Id = dbUser.Id,
                    Username = dbUser.Username,
                    FirstName = dbUser.FirstName,
                    LastName = dbUser.LastName,
                };
            }
            return retValue;
        }

        public Task<Entities.User> GetEntityByUsername(string username)
        {
            return this._repository.GetByUsernameAsync(username);
        }

        public Task Insert(DTO.User user)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Task Update(DTO.User user, string id)
        {
            //TODO
            throw new NotImplementedException();
        }

        public Task Delete(string id)
        {
            throw new NotImplementedException();
        }
    }
}