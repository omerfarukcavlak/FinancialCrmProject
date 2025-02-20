using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.DataAccess.Contexts;
using FinancialCRM.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace FinancialCRM.DataAccess.Concrete
{
    public class RegisterDal(BankDbContext db) : IRegisterDal
    {

        DbSet<User> _set = db.Set<User>();
        public bool Add(User entity)
        {
            _set.Add(entity);
            return db.SaveChanges() > 0;
        }

        public bool EmailExists(string email)
            => !db.Users.Any(u => u.Email == email);

        public User Get(Expression<Func<User, bool>> expression)
            => _set.FirstOrDefault(expression);

        public bool Update(User entity)
        {
            _set.Update(entity);
            return db.SaveChanges() > 0;
        }

        public bool UsernameExists(string username)
            => !db.Users.Any(u => u.Username == username);
    }
}
