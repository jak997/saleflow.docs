using BLL.DTO;
using BLL.Repositories;
using BLL.Services.Core;
using Entities;
using System.Collections;
using System.Linq.Expressions;

namespace BLL.Services
{
    public class QuoteService : ConnectedBaseService<IQuoteRepository>, IQuoteService
    {
        public QuoteService( IQuoteRepository repository) : base(repository) { }

        public Task Create(DTO.Quote quote)
        {
            throw new NotImplementedException(); //todo
        }

        public Task Delete(DTO.Quote quote)
        {
            throw new NotImplementedException();
        }

        public Task<DTO.Quote> GetById(string id)
        {
            throw new NotImplementedException(); //todo
        }

        public Task Update(DTO.Quote quote, string version)
        {
            throw new NotImplementedException();
        }
    }
}