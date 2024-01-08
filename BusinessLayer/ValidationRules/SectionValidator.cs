using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class SectionValidator : AbstractValidator<Section>
    {
        public SectionValidator()
        {
            RuleFor(x => x.SectionName).NotEmpty().WithMessage("Bölüm adını boş geçemezsiniz.");
            RuleFor(x => x.SectionDescription).NotEmpty().WithMessage("Bölüm açıklamasını boş geçemezsiniz.");
        }
    }
}
