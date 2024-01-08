using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PostValidator: AbstractValidator<Post>
    {
        public PostValidator()
        {
            RuleFor(x => x.PostTitle).NotEmpty().WithMessage("Gönderi başlığını boş geçemezsiniz.");
            RuleFor(x => x.PostContent).NotEmpty().WithMessage("Gönderi içeriğini boş geçemezsiniz.");
        }
    }
}
