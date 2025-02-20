using FinancialCRM.Business.Abstract;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Concrete
{
    public class BankManager(IBankDal dal, IValidator<Bank> validator) : IBankService
    {

        public bool Add(Bank entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Add(entity);

        }

        public bool Delete(Bank entity)
            => dal.Delete(entity);


        public Bank Get(Expression<Func<Bank, bool>> filter = null)
            => dal.Get(filter);

        public IQueryable<Bank> GetAll()
            => dal.GetAll();

        public IQueryable<Bank> GetAll(Expression<Func<Bank, bool>> filter = null)
            => dal.GetAll(filter);
        
        public bool Update(Bank entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Update(entity);
        }
    }
}
