using FluentValidation;
using MyBlog.Entities.Dtos.ArticleDtos;
using MyBlog.Shared.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.ValidationRules.FluentValidation.ArticleValidators
{
    public class ArticleAddDtoValidator : AbstractValidator<ArticleAddDto>
    {
        public ArticleAddDtoValidator()
        {
            RuleFor(x => x.Title).NotEmpty().WithMessage("Makale Başlığı" + ValidationMessages.NotEmpty);
            RuleFor(x => x.Title).MaximumLength(200).WithMessage("Makale Başlığı" + ValidationMessages.MustLessThen200);
            RuleFor(x => x.Title).MinimumLength(3).WithMessage("Makale Başlığı" + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.Content).NotEmpty().WithMessage("Makale İçeriği" + ValidationMessages.NotEmpty);
            RuleFor(x => x.Content).MinimumLength(3).WithMessage("Makale İçeriği" + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.Thumbnail).NotEmpty().WithMessage("Thumbnail" + ValidationMessages.NotEmpty);
            RuleFor(x => x.Thumbnail).MaximumLength(250).WithMessage("Thumbnail" + ValidationMessages.MustLessThen250);
            RuleFor(x => x.Thumbnail).MinimumLength(3).WithMessage("Thumbnail" + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.Date).NotEmpty().WithMessage("Tarih" + ValidationMessages.NotEmpty);

            RuleFor(x => x.SeoAuthor).NotEmpty().WithMessage("Seo Yazar" + ValidationMessages.NotEmpty);
            RuleFor(x => x.SeoAuthor).MaximumLength(100).WithMessage("Seo Yazar" + ValidationMessages.MustLessThen100);
            RuleFor(x => x.SeoAuthor).MinimumLength(3).WithMessage("Seo Yazar" + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.SeoDescription).NotEmpty().WithMessage("Seo Açıklama" + ValidationMessages.NotEmpty);
            RuleFor(x => x.SeoDescription).MaximumLength(250).WithMessage("Seo Açıklama" + ValidationMessages.MustLessThen250);
            RuleFor(x => x.SeoDescription).MinimumLength(3).WithMessage("Seo Açıklama" + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.SeoTags).NotEmpty().WithMessage("Seo Etiketleri" + ValidationMessages.NotEmpty);
            RuleFor(x => x.SeoTags).MaximumLength(250).WithMessage("Seo Etiketleri" + ValidationMessages.MustLessThen250);
            RuleFor(x => x.SeoTags).MinimumLength(3).WithMessage("Seo Etiketleri" + ValidationMessages.MustMoreThen3);

            RuleFor(x => x.CategoryId).NotEmpty().WithMessage("Kategori" + ValidationMessages.NotEmpty);

            RuleFor(x => x.IsActive).NotEmpty().WithMessage("Aktif mi? " + ValidationMessages.NotEmpty);
        }
    }
}

