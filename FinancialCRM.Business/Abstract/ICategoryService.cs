using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Abstract
{
    public interface ICategoryService
    {
        bool Add(Category entity);
        bool Update(Category entity);
        bool Delete(Category entity);
        IQueryable<Category> GetAll();
        IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter = null);
        Category Get(Expression<Func<Category, bool>> filter = null);
    }
}
