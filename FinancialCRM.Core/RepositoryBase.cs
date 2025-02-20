using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FinancialCRM.Core
{
    public class RepositoryBase<T>(DbContext db) : IRepositoryBase<T> where T : BaseEntity, new()
    {
        DbSet<T> _set = db.Set<T>();
        public bool Add(T entity)
        {
            _set.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool Delete(T entity)
        {
            _set.Remove(entity);
            return db.SaveChanges() > 0;
        }

        public T Get(Expression<Func<T, bool>> expression)
        => _set.FirstOrDefault(expression);

        public IQueryable<T> GetAll()
        => _set;

        public IQueryable<T> GetAll(Expression<Func<T, bool>> expression)
        => _set.Where(expression);

        public bool Update(T entity)
        {
            _set.Update(entity);
            return db.SaveChanges() > 0;
        }
    }
}
