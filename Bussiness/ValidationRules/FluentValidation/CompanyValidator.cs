﻿using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class CompanyValidator :AbstractValidator<Company>
    {
        public CompanyValidator()
        {
            RuleFor(p => p.Name).NotEmpty().WithMessage("Şirket adı boş olamaz.");
            RuleFor(p => p.Name).MinimumLength(4).WithMessage("Şirket adı en az 4 karakter olmalıdır.");
            RuleFor(p => p.Address).NotEmpty().WithMessage("Şirket adresi boş olamaz. ");
        }
    }
}
