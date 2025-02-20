using FinancialCRM.Entities.Concrete;
using System.Linq.Expressions;

namespace FinancialCRM.DataAccess.Abstract
{
    public interface IRegisterDal 
    {
        bool Add(User entity);
        bool Update(User entity);
        User Get(Expression<Func<User, bool>> expression);
        bool EmailExists(string email);
        bool UsernameExists(string username);
    }
}
