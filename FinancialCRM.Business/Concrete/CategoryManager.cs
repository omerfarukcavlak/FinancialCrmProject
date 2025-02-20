using FinancialCRM.Business.Abstract;
using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using System.Linq.Expressions;

namespace FinancialCRM.Business.Concrete
{
    public class CategoryManager(ICategoryDal dal, IValidator<Category> validator) : ICategoryService
    {
        public bool Add(Category entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Add(entity);
        }

        public bool Delete(Category entity)
            => dal.Delete(entity);


        public Category Get(Expression<Func<Category, bool>> filter = null)
            => dal.Get(filter);

        public IQueryable<Category> GetAll()
            => dal.GetAll();

        public IQueryable<Category> GetAll(Expression<Func<Category, bool>> filter = null)
            => dal.GetAll(filter);

        public bool Update(Category entity)
        {
            var result = validator.Validate(entity);

            if (!result.IsValid)
                throw new ValidationException(result.Errors);
            else
                return dal.Update(entity);
        }
    }
}
