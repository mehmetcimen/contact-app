using Core.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class ContactCreateDtoValidator:AbstractValidator<ContactCreateDto>
    {
        public ContactCreateDtoValidator()
        {

            RuleFor(x => x.Name).NotNull().WithMessage("{PropertyName} Gereklidir").NotEmpty().
                WithMessage("{PropertyName} Gereklidir");

            RuleFor(x => x.Surname).NotNull().WithMessage("{PropertyName} Gereklidir").NotEmpty().
                WithMessage("{PropertyName} Gereklidir");


        }
    }
}
