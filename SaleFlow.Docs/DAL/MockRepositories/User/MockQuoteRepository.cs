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
            throw new NotImplementedException();      //todo
        }

        public void Delete(User entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            throw new NotImplementedException();     //todo
        }

        public void Update(User entity)
        {
            throw new NotImplementedException(); 
        }
    }
}
