using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.Services
{
    public interface IQuoteService
    {
        public Task<BLL.DTO.Quote> GetById(string id);
        public Task Create(BLL.DTO.Quote quote);
        public Task Update(BLL.DTO.Quote quote, string version);

        public Task Delete(BLL.DTO.Quote quote);
    }
}
