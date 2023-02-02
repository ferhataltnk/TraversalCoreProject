using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class AboutValidator : AbstractValidator<About>
    {
        public AboutValidator()
        {
            RuleFor(p => p.Description).NotEmpty().WithMessage("Açıklama kısmı boş bırakılamaz!");
           
            RuleFor(p => p.Image1).NotEmpty().WithMessage("Lütfen Görsel Seçiniz...!");

            RuleFor(p => p.Description).MinimumLength(50).WithMessage("Açıklama en az 50 karakter olmalıdır.");

        }
    }
}
