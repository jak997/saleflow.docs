using BLL.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class UserRepository : BaseRepository<Entities.User> , IUserRepository
    {
        public UserRepository(Context context) : base(context)
        {
        }

        public Task<User> GetByUsernameAsync(string username)
        {
            return this._dbSet.SingleOrDefaultAsync(u => u.Username == username);
        }
    }
}
