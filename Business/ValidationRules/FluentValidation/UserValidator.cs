using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Business.ValidationRules.FluentValidation
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(u => u.Id).NotEmpty();
            RuleFor(u=> u.FirstName).NotEmpty();
            RuleFor(u => u.LastName).NotEmpty();
            RuleFor(u => u.Email).EmailAddress();
            RuleFor(u => u.Password).NotEmpty().Must(IsPasswordValid).WithMessage("Parola en az 8 karakterden oluşmalı, en az bir sayı ve en az bir harf içermelidir!");
        }

        private bool IsPasswordValid(string arg)
        {
            Regex regex = new Regex(@"^(?=.*[A-Za-z])(?=.*\d)[A-Za-z\d]{8,}$");
            return regex.IsMatch(arg);
        }

        //Regex bir string ifadenin (metin) belirli kurallara uyumluluğunu kontrol etmeye ve düzenlemeye yarar.
        //Regex ile bir alana sadece harf mi girilmiş, rakam mı girilmiş ya da eposta adresi mi girilmiş kontrol edebilirsiniz.
        //C# içerisinde Regex kullanabilmek için System.Text.RegularExpression kütüphanesini eklememiz gerekmektedir.

    }
}
