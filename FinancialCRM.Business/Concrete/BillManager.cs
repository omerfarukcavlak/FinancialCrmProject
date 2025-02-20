using FinancialCRM.Business.Abstract;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Concrete
{
    public class BillManager(IBillDal dal, IValidator<Bill> validator) : IBillService
    {
        public bool Add(Bill entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Add(entity);
        }

        public bool Delete(Bill entity)
            => dal.Delete(entity);


        public Bill Get(Expression<Func<Bill, bool>> filter = null)
            => dal.Get(filter);

        public IQueryable<Bill> GetAll()
            => dal.GetAll();

        public IQueryable<Bill> GetAll(Expression<Func<Bill, bool>> filter = null)
            => dal.GetAll(filter);

        public bool Update(Bill entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Update(entity);
        }
    }
}
