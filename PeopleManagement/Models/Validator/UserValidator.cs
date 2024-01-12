using FluentValidation;

namespace PeopleManagement.Models.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Email).NotNull().WithMessage("Email can not be Empty =D");
            RuleFor(user => user.Email).EmailAddress().WithMessage("Have to be a valid email");
            RuleFor(user => user.Password).NotNull().WithMessage("Pass is mandatory");

        }
    }
}
