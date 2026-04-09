using BLL.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Mock
{
    public class MockUserRepository : IUserRepository
    {
        List<User> fakeDbSet = new List<Entities.User>
            {
                new() { Id = "Zwdawdba2-asc2vfdaa", Username = "uOsso", FirstName = "Osso", LastName = "Beato", Password = "PasswordDaCambiare01$" },
                new() { Id = "c37aw2a22-Usasc3fda", Username = "uMastrosso", FirstName = "Mastrosso", LastName = "Beato", Password = "PasswordDaCambiare01$" },
                new() { Id = "asd1dba22-ascqagfda", Username = "uCarcagnosso", FirstName = "Carcagnosso", LastName = "Beato", Password = "PasswordDaCambiare01$" }
            };

        public MockUserRepository()
        {
        }

        public Task<User> GetByUsernameAsync(string username)
        {
            User result = fakeDbSet.SingleOrDefault(u => u.Username == username);
            return Task.FromResult(result);
        }

        public Task<Entities.User> GetByIdAsync(string id)
        {
            Entities.User result = Activator.CreateInstance<Entities.User>();
            result.Id = id;
            return Task.FromResult(result);
        }
        public Task<List<Entities.User>> GetAllAsync()
        {
            return Task.FromResult(fakeDbSet);
        }
        public void Add(Entities.User entity) { }
        public void Update(Entities.User entity) { }
        public void Delete(Entities.User entity) { }
        public Task SaveChangesAsync() { return Task.Delay(300); }
        public Task<List<Entities.User>> GetByPredicateAsync(Expression<Func<Entities.User, bool>> predicate)
        {
            var filteredResults = fakeDbSet.AsQueryable().Where(predicate).ToList();

            return Task.FromResult(filteredResults);
        }
    }
}
