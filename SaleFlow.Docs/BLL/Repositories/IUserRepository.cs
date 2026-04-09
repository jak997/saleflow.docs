using Entities;

namespace BLL.Repositories
{
    public interface IUserRepository : IRepository<Entities.User>
    {
        Task<Entities.User> GetByIdAsync(string id);
        Task<Entities.User> GetByUsernameAsync(string username);
    }
}
