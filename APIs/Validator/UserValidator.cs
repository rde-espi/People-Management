using Common;
using FluentValidation;

namespace APIs.Validator
{
    public class UserValidator : AbstractValidator<UserModel>
    {
        public UserValidator()
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Email can not be Empty =D");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Have to be a valid email");
            RuleFor(user => user.Password).NotNull().WithMessage("Pass is mandatory");
            RuleFor(user => user.Password).NotNull().WithMessage("Pass is mandatory");
            RuleFor(user => user.Username).NotNull().WithMessage("Username is empty");
            RuleFor(user => user.Password).NotNull().WithMessage("Pass is mandatory");
            RuleFor(user => user.Password).Equal(o => o.ConfirmPassword).WithMessage("Passwords are not equals");

        }
    }
}
