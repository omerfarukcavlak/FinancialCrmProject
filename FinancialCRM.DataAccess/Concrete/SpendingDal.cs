using FinancialCRM.Core;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.DataAccess.Concrete
{
    public class SpendingDal : RepositoryBase<Spending>, ISpendingDal
    {
        public SpendingDal(DbContext db) : base(db)
        {
        }
    }
}
