using FinancialCRM.Entities.Concrete;
using FluentValidation;

namespace FinancialCRM.Business.Validation.FluentValidation
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName)
            .NotEmpty().WithMessage("Kategori ismi boş olamaz.");


        }
    }
}
