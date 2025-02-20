using FinancialCRM.Core;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.DataAccess.Concrete
{
    public class BankDal : RepositoryBase<Bank>, IBankDal
    {
        public BankDal(DbContext db) : base(db)
        {
        }
    }
}
