using FluentValidation;
using MyBlog.Entities.Dtos.UserDtos;
using MyBlog.Shared.Constants.Messages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Business.ValidationRules.FluentValidation.UserValidators
{
    public class UserAddDtoValidator : AbstractValidator<UserAddDto>
    {
        public UserAddDtoValidator()
        {
            RuleFor(x => x.UserName).NotEmpty().WithMessage("Kullanıcı adı " + ValidationMessages.NotEmpty);
            RuleFor(x => x.UserName).MaximumLength(50).WithMessage("Kullanıcı adı " +  ValidationMessages.MustLessThen50);
            RuleFor(x => x.UserName).MinimumLength(2).WithMessage("Kullanıcı adı " + ValidationMessages.MustMoreThen2);
            RuleFor(x => x.Email).NotEmpty().WithMessage("Email " + ValidationMessages.NotEmpty);
            RuleFor(x => x.Email).EmailAddress().WithMessage(ValidationMessages.MustBeEmail);
            RuleFor(x => x.Email).MaximumLength(100).WithMessage("Email " + ValidationMessages.MustLessThen100);
            RuleFor(x => x.Email).MinimumLength(3).WithMessage("Email " + ValidationMessages.MustMoreThen3);
            RuleFor(x => x.Password).NotEmpty().WithMessage("Şifre " + ValidationMessages.NotEmpty);
            RuleFor(x => x.Password).MaximumLength(30).WithMessage("Şifre " + ValidationMessages.MustLessThen30);
            RuleFor(x => x.Password).MinimumLength(5).WithMessage("Şifre " + ValidationMessages.MustMoreThen5);
            RuleFor(x => x.PhoneNumber).NotEmpty().WithMessage("Telefon " + ValidationMessages.NotEmpty);
            RuleFor(x => x.PhoneNumber).MaximumLength(13).WithMessage("Telefon " + ValidationMessages.MustLessThen13);
            RuleFor(x => x.PhoneNumber).MinimumLength(13).WithMessage("Telefon " + ValidationMessages.MustMoreThen13);
            RuleFor(x => x.Picture).NotEmpty().WithMessage("Fotoğraf " + ValidationMessages.NotEmpty);
        }
    }
}
