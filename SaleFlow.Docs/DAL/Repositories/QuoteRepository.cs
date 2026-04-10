using BLL.Repositories;
using Entities;
using Microsoft.EntityFrameworkCore;

namespace DAL.Repositories
{
    public class QuoteRepository : BaseRepository<Entities.User> , IQuoteRepository
    {
        public QuoteRepository(Context context) : base(context)
        {
        }
    }
}
