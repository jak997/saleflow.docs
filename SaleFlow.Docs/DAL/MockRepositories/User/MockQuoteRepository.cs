using BLL.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Mock
{
    public class MockQuoteRepository : IQuoteRepository
    {
        List<User> fakeDbSet = new List<Entities.User>
            {
            //todo
        };

        public MockQuoteRepository()
        {
        }

        public void Add(User entity)
        {
            Console.WriteLine("MockQuoteRepository.Add");
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            return Task.Delay(1000);
        }

        public void Update(User entity)
        {
            throw new NotImplementedException(); 
        }
    }
}
