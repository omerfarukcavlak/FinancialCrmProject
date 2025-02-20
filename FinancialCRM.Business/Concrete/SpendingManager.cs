using FinancialCRM.Business.Abstract;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Concrete
{
    public class SpendingManager (ISpendingDal dal, IValidator<Spending> validator) : ISpendingService
    {
        public bool Add(Spending entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Add(entity);

        }

        public bool Delete(Spending entity)
            => dal.Delete(entity);


        public Spending Get(Expression<Func<Spending, bool>> filter = null)
            => dal.Get(filter);

        public IQueryable<Spending> GetAll()
            => dal.GetAll();

        public IQueryable<Spending> GetAll(Expression<Func<Spending, bool>> filter = null)
            => dal.GetAll(filter);

        public bool Update(Spending entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Update(entity);
        }
    }
}
