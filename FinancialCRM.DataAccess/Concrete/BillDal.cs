using FinancialCRM.Core;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.DataAccess.Concrete
{
    public class BillDal : RepositoryBase<Bill>, IBillDal
    {
        public BillDal(DbContext db) : base(db)
        {
        }
    }
}
