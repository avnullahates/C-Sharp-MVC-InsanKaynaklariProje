using CoreLayer.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class PersonnelValidator : AbstractValidator<Personnel>
    {
        public PersonnelValidator()
        {
            RuleFor(p => p.Name).NotNull().WithMessage("Adınızı giriniz!");
            RuleFor(p => p.Surname).NotNull().WithMessage("Soyadınızı giriniz!");
            RuleFor(p => p.BirthDate).NotNull().WithMessage("Doğum tarihinizi giriniz!");
            RuleFor(p => p.IdentityNumber).NotNull().Length(11,11).WithMessage("TC Kimlik numarası 11 hane olarak girilmelidir!");
            //RuleFor(p => p.Password).NotNull().WithMessage("Parola boş geçilemez!");
            RuleFor(p => p.PlaceOfBirth).NotNull().WithMessage("Doğum yerinizi girmelisiniz!");
            RuleFor(p => p.HireDate).NotNull().WithMessage("İşe giriş tarihinizi girmelisiniz!");
            RuleFor(p => p.Job).NotNull().WithMessage("Mesleğinizi girmelisiniz!");
            RuleFor(p => p.Gender).NotNull().WithMessage("Cinsiyetinizi girmelisiniz!");
        }
    }
}
