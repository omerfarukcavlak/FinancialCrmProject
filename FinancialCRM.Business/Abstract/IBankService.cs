using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Abstract
{
    public interface IBankService
    {
        bool Add(Bank entity);
        bool Update(Bank entity);
        bool Delete(Bank entity);
        IQueryable<Bank> GetAll();
        IQueryable<Bank> GetAll(Expression<Func<Bank, bool>> filter = null);
        Bank Get(Expression<Func<Bank, bool>> filter = null);
    }
}
