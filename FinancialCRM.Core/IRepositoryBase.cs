using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Core
{
    public interface IRepositoryBase<T> where T : BaseEntity, new()
    {
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(T entity);
        IQueryable<T> GetAll();
        IQueryable<T> GetAll(Expression<Func<T, bool>> expression);
        T Get(Expression<Func<T, bool>> expression);
    }
}
