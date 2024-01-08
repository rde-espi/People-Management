using FluentValidation;

namespace PeopleManagement.Models.Validator
{
    public class UserValidator : AbstractValidator<UserViewModel>
    {
        public UserValidator() 
        {
            RuleFor(user => user.Email).NotNull();
            //RuleFor(user => user.Username).NotNull();
            RuleFor(user => user.Password).NotNull();

        }
    }
}
