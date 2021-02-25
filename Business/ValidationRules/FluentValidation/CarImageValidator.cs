using System;
using System.Collections.Generic;
using System.Text;
using Entites.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator : AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(x => x.ImagePath).NotEmpty();
            //https://www.codeproject.com/Questions/763045/csharp-guid-code-for-image-name
        }
    }
}
