using FluentValidation;

namespace LibraryManagement_CodeFirst.Models.FluentValidators
{
    public class AuthorValidator : AbstractValidator<Author>
    {
        public AuthorValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().NotNull().WithMessage("Required Field")
                .MaximumLength(15).WithMessage("Max 15 characters");
            RuleFor(x => x.LastName).NotEmpty().NotNull().WithMessage("Required Field");
        }
    }
}
