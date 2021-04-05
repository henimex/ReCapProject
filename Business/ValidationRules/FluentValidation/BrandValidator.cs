using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(x => x.BrandName).MinimumLength(2);
            RuleFor(x => x.BrandName).MaximumLength(10);
            RuleFor(x => x.BrandName).Must(StartWithA).WithMessage("Brand Name Must be Start With A");
        }

        private bool StartWithA(string arg)
        {
            return arg.StartsWith("A");
        }
    }
}
