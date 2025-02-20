using FinancialCRM.Core;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace FinancialCRM.DataAccess.Concrete
{
    public class CategoryDal : RepositoryBase<Category>, ICategoryDal
    {
        public CategoryDal(DbContext db) : base(db)
        {
        }
    }
}
