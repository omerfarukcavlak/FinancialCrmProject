using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Abstract
{
    public interface IRegisterService
    {
        bool Add(User entity);
        bool Update(User entity);
        User Get(Expression<Func<User, bool>> filter = null);

    }
}
