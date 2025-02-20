using FinancialCRM.Entities.Concrete;
using FluentValidation;

namespace FinancialCRM.Business.Validation.FluentValidation
{
    public class BankValidator : AbstractValidator<Bank>
    {
        public BankValidator()
        {
            RuleFor(x => x.AccountNumber)
                .NotEmpty().WithMessage("Hesap Numarası boş olamaz.")
                .Length(19).WithMessage("Hesap Numarası 16 karakter uzunluğunda olmalı.")
                .Matches(@"^\d{4}-\d{4}-\d{4}-\d{4}$")
                .WithMessage("Hesap numarası '0000-1111-2222-3333' formatında olmalıdır.");


            RuleFor(x => x.Title)
                .NotEmpty().WithMessage("Banka ismi boş geçilemez.");

            RuleFor(x => x.Balance)
                .GreaterThanOrEqualTo(0).WithMessage("Bakiye 0 veya daha büyük olmalıdır."); ;


        }
    }
}
