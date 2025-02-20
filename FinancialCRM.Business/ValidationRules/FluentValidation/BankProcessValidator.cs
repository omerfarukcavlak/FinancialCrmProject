using FinancialCRM.Entities.Concrete;
using FluentValidation;

namespace FinancialCRM.Business.Validation.FluentValidation
{
    public class BankProcessValidator : AbstractValidator<BankProcess>
    {
        public BankProcessValidator()
        {
            RuleFor(x => x.Description)
                .NotEmpty().WithMessage("Açıklama boş bırakılamaz.");

            RuleFor(x => x.ProcessDate)
                .NotEmpty().WithMessage("İşlem Tarihi boş bırakılamaz.");

            RuleFor(x => x.ProcessType)
                .IsInEnum().WithMessage("Geçerli bir işlem tipi seçilmelidir.");

            RuleFor(x => x.Amount)
                .NotEmpty().WithMessage("Bakiye boş bırakılamaz.");

        }
    }
}
