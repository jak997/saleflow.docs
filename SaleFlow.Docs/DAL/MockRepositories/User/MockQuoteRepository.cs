using BLL.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories.Mock
{
    public class MockQuoteRepository : IQuoteRepository
    {
        List<Quote> fakeDbSet = new List<Entities.Quote>
            {
            //todo
        };

        public MockQuoteRepository()
        {
        }

        public void Add(Quote entity)
        {
            Console.WriteLine("MockQuoteRepository.Add");
        }

        public void Delete(Quote entity)
        {
            throw new NotImplementedException();
        }

        public Task SaveChangesAsync()
        {
            return Task.Delay(1000);
        }

        public void Update(Quote entity)
        {
            throw new NotImplementedException(); 
        }
    }
}
