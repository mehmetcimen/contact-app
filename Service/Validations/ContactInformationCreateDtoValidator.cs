using Core.Dto;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Validations
{
    public class ContactInformationCreateDtoValidator: AbstractValidator<ContactInformationCreateDto>
    {

        public ContactInformationCreateDtoValidator()
        {
            RuleFor(x => x.Phone).NotNull().WithMessage("{PropertyName} Gereklidir").NotEmpty().
              WithMessage("{PropertyName} Gereklidir");
        }
    }
}
