using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator : AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(x => x.ModelYear).MinimumLength(4);
            RuleFor(x => x.DailyPrice).GreaterThan(0);
            RuleFor(x => x.DailyPrice).NotEmpty();
            RuleFor(x => x.DailyPrice).GreaterThanOrEqualTo(250).When(x => x.BrandId == 2);

        }
    }
}
