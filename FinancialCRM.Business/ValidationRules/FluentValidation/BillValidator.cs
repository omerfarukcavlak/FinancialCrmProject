using FinancialCRM.Entities.Concrete;
using FluentValidation;

namespace FinancialCRM.Business.Validation.FluentValidation
{
    public class BillValidator : AbstractValidator<Bill>
    {
        public BillValidator()
        {
            RuleFor(x => x.Period)
                .NotEmpty().WithMessage("Peryiot boş olamaz.");

            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Fatura ismi boş geçilemez.");

            RuleFor(x=>x.Amount)
                .GreaterThanOrEqualTo(0).WithMessage("Bakiye 0 veya daha büyük olmalıdır."); ;

        }
    }
}
