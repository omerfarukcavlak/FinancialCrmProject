using FinancialCRM.Entities.Concrete;
using FluentValidation;

namespace FinancialCRM.Business.Validation.FluentValidation
{
    public class SpendingValidator : AbstractValidator<Spending>
    {
        public SpendingValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Harcama açıklaması boş geçilemez.");

            RuleFor(x => x.Amount)
                .GreaterThanOrEqualTo(0).WithMessage("Bakiye 0 veya daha büyük olmalıdır."); ;

        }
    }
}
