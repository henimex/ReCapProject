using System;
using System.Collections.Generic;
using System.Text;
using Business.Constants;
using Core.Entities.Concrete;
using Entites.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator: AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(x => x.LastName).NotEmpty().NotNull().MinimumLength(4);
            RuleFor(x => x.FirstName).NotEmpty().NotNull().MinimumLength(4).WithMessage(Messages.NotNull);
            //RuleFor(x => x.PasswordHash).NotEmpty().NotNull().MinimumLength(4);
        }
    }
}
