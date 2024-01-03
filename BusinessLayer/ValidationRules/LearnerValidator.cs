using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class LearnerValidator: AbstractValidator<Learner>
    {
        public LearnerValidator()
        {
            RuleFor(x => x.LearnerName).NotEmpty().WithMessage("Lütfen isminizi girin!");
            RuleFor(x => x.LearnerSurname).NotEmpty().WithMessage("Lütfen soyisminizi girin!");
            RuleFor(x => x.LearnerMail).NotEmpty().WithMessage("Lütfen mailinizi girin!");
            RuleFor(x => x.LearnerPassword).NotEmpty().WithMessage("Lütfen şifrenizi girin!");
            RuleFor(x => x.LearnerName).NotEmpty().WithMessage("Lütfen isminizi girin!");
            RuleFor(x => x.LearnerName).MinimumLength(2).WithMessage("Lütfen en az 2 karakter girin!");
            RuleFor(x => x.LearnerName).MaximumLength(30).WithMessage("Lütfen 30 karakteri aşmayın!");
        }
    }
}
