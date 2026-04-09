using BLL.Repositories;
using DAL;
using Entities.Core;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DAL.Repositories
{
    public abstract class BaseRepository<T> : IRepository<T> where T : BaseUniqueIdentifiedEntity
    {
        protected readonly Context _context;
        protected readonly DbSet<T> _dbSet;

        protected BaseRepository(Context context)
        {
            _context = context;
            _dbSet = context.Set<T>();
        }

        public Task<T?> GetByIdAsync(string id) { return _dbSet.SingleOrDefaultAsync(x => x.Id == id); }
        public Task<List<T>> GetAllAsync() { return _dbSet.ToListAsync(); }
        public void Add(T entity) { _dbSet.Add(entity); }
        public void Update(T entity) { _dbSet.Update(entity); }
        public void Delete(T entity) { _dbSet.Remove(entity); }
        public Task SaveChangesAsync() { return _context.SaveChangesAsync(); }
        public Task<List<T>> GetByPredicateAsync(Expression<Func<T, bool>> predicate)
        {
            return _dbSet
                .AsNoTracking()
                .Where(predicate)
                .ToListAsync();
        }
    }
}