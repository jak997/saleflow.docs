using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace BLL.Repositories
{
    public interface IRepository<T>  where T : class
    {
        Task<List<T>> GetAllAsync();
        Task<List<T>> GetByPredicateAsync(Expression<Func<T, bool>> predicate);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        Task SaveChangesAsync();
    }
}
