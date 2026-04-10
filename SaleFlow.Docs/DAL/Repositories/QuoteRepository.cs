using BLL.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class QuoteRepository : BaseRepository<Entities.Quote> , IQuoteRepository
    {
        public QuoteRepository(Context context) : base(context)
        {
        }
    }
}
