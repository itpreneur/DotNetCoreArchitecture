using DotNetCore.Validation;
using DotNetCoreArchitecture.Model.Models;
using FluentValidation;

namespace DotNetCoreArchitecture.Model.Validators
{
    public sealed class AddUserModelValidator : Validator<AddUserModel>
    {
        public AddUserModelValidator() : base(string.Empty)
        {
            RuleFor(x => x).NotNull();
            RuleFor(x => x.Name).NotNull().NotEmpty();
            RuleFor(x => x.Surname).NotNull().NotEmpty();
            RuleFor(x => x.Email).NotNull().NotEmpty();
            RuleFor(x => x.Login).NotNull().NotEmpty();
            RuleFor(x => x.Password).NotNull().NotEmpty();
        }
    }
}
