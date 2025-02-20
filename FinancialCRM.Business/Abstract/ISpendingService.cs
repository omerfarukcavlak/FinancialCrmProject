using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Abstract
{
    public interface ISpendingService
    {
        bool Add(Spending entity);
        bool Update(Spending entity);
        bool Delete(Spending entity);
        IQueryable<Spending> GetAll();
        IQueryable<Spending> GetAll(Expression<Func<Spending, bool>> filter = null);
        Spending Get(Expression<Func<Spending, bool>> filter = null);
    }
}
