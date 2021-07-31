using EcomWeb.Contracts.Constants;
using EcomWeb.Contracts.Dtos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EcomWeb.WebApp.Validators
{
    public class CategoryDtoValidator : BaseValidator<CategoryDto>
    {
        public CategoryDtoValidator(CategoryDto m)
        {
            RuleFor(m => m.Id)
                 .NotNull()
                 .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Id)));

            RuleFor(m => m.Name)
                  .NotEmpty()
                  .WithMessage(x => string.Format(ErrorTypes.Common.RequiredError, nameof(x.Name)));

            RuleFor(m => m.Name)
               .MaximumLength(ValidationRules.CategoryRules.MaxLenghCharactersForName)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.CategoryRules.MaxLenghCharactersForName))
               .When(m => !string.IsNullOrWhiteSpace(m.Name));

            RuleFor(m => m.Desc)
               .MaximumLength(ValidationRules.CategoryRules.MaxLenghCharactersForDesc)
               .WithMessage(string.Format(ErrorTypes.Common.MaxLengthError, ValidationRules.CategoryRules.MaxLenghCharactersForDesc))
               .When(m => !string.IsNullOrWhiteSpace(m.Desc));
        }
    }
}
