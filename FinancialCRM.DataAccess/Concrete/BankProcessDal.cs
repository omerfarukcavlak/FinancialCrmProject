using FinancialCRM.Core;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.DataAccess.Concrete
{
    public class BankProcessDal : RepositoryBase<BankProcess>, IBankProcessDal
    {
        public BankProcessDal(DbContext db) : base(db)
        {
        }
    }
}
