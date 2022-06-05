using FluentValidation;
using MyBlog.Entities.Dtos.CategoryDtos;
using MyBlog.Shared.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.ValidationRules.FluentValidation.CategoryValidators
{
    public class CategoryAddDtoValidator : AbstractValidator<CategoryAddDto>
    {
        public CategoryAddDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori Adı " + ValidationMessages.NotEmpty);
            RuleFor(x => x.Name).MaximumLength(100).WithMessage("Kategori Adı " + ValidationMessages.MustLessThen100);
            RuleFor(x => x.Name).MinimumLength(3).WithMessage("Kategori Adı " + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.Description).MaximumLength(500).WithMessage("Kategori Açıklaması " + ValidationMessages.MustLessThen500);
            RuleFor(x => x.Description).MinimumLength(3).WithMessage("Kategori Açıklaması " + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.Note).MaximumLength(500).WithMessage("Kategori Özel Not Alanı " + ValidationMessages.MustLessThen500);
            RuleFor(x => x.Note).MinimumLength(3).WithMessage("Kategori Özel Not Alanı " + ValidationMessages.MustMoreThen3);
        }
    }
}
