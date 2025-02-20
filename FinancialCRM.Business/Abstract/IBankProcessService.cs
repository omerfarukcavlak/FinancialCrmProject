using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Abstract
{
    public interface IBankProcessService
    {
        bool Add(BankProcess entity);
        bool Update(BankProcess entity);
        bool Delete(BankProcess entity);
        IQueryable<BankProcess> GetAll();
        IQueryable<BankProcess> GetAll(Expression<Func<BankProcess, bool>> filter = null);
        BankProcess Get(Expression<Func<BankProcess, bool>> filter = null);
    }
}
