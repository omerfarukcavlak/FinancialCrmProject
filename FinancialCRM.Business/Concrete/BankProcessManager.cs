using FinancialCRM.Business.Abstract;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Concrete
{
    public class BankProcessManager (IBankProcessDal dal, IValidator<BankProcess> validator) : IBankProcessService
    {
        public bool Add(BankProcess entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Add(entity);

        }

        public bool Delete(BankProcess entity)
            => dal.Delete(entity);


        public BankProcess Get(Expression<Func<BankProcess, bool>> filter = null)
            => dal.Get(filter);

        public IQueryable<BankProcess> GetAll()
            => dal.GetAll();

        public IQueryable<BankProcess> GetAll(Expression<Func<BankProcess, bool>> filter = null)
            => dal.GetAll(filter);

        public bool Update(BankProcess entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Update(entity);
        }
    }
}
