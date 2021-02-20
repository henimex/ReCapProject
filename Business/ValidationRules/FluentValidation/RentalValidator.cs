using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class RentalValidator : AbstractValidator<Rental>
    {
        public RentalValidator()
        {
            RuleFor(x => x.CarId).NotEmpty().NotNull();
            RuleFor(x => x.CustomerId).NotEmpty().NotNull();
            RuleFor(x => x.CarId).NotEmpty().NotNull();
        }
    }
}
