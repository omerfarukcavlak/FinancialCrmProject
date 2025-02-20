using FinancialCRM.DataAccess.Abstract;
using FinancialCRM.Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace FinancialCRM.Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        private readonly IRegisterDal _registerDal;
        public UserValidator( IRegisterDal registerDal)
        {
            _registerDal = registerDal;

            RuleFor(p => p.FirstName)
                .NotEmpty().WithMessage("First name cannot be empty.")
                .Matches("^[A-Za-zçÇşŞğĞıİöÖüÜ]+(?: [A-Za-zçÇşŞğĞıİöÖüÜ]+)*$")
                .WithMessage("First name can only contain letters and spaces.");

            RuleFor(p => p.LastName)
                .NotEmpty().WithMessage("Last name cannot be empty.")
                .Matches("^[A-Za-zçÇşŞğĞıİöÖüÜ]+(?: [A-Za-zçÇşŞğĞıİöÖüÜ]+)*$")
                .WithMessage("Last name can only contain letters and spaces.");

            RuleFor(p => p.Username)
                .NotEmpty().WithMessage("Username cannot be empty.")
                 .Matches("^[A-Za-z._]+$")
                .WithMessage("Username can only contain letters. and the following punctuation marks: . _")
                .Must(IsUsernameUnique).WithMessage("The username is already taken.");

            RuleFor(p => p.Email)
                .NotEmpty().WithMessage("Email cannot be empty.")
                .EmailAddress().WithMessage("Please enter a valid email address.")
                .Must(IsEmailUnique).WithMessage("The email is already registered.");

            RuleFor(p => p.Password)
                .NotEmpty().WithMessage("Password cannot be empty.");

            RuleFor(p => p.Password)
                .Equal(p => p.ConfirmPassword).WithMessage("Password and Confirm Password must match.");
            
        }

        private bool IsEmailUnique(string email)
            => _registerDal.EmailExists(email);

        private bool IsUsernameUnique(string username)
            => _registerDal.UsernameExists(username);
    }
}
