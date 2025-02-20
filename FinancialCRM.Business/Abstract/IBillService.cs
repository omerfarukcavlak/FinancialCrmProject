using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Abstract
{
    public interface IBillService
    {
        bool Add(Bill entity);
        bool Update(Bill entity);
        bool Delete(Bill entity);
        IQueryable<Bill> GetAll();
        IQueryable<Bill> GetAll(Expression<Func<Bill, bool>> filter = null);
        Bill Get(Expression<Func<Bill, bool>> filter = null);
    }
}
