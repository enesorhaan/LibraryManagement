using FluentValidation;
using System.Security.Cryptography.X509Certificates;

namespace LibraryManagement_CodeFirst.Models.FluentValidators
{
    public class BookValidator : AbstractValidator<Book>
    {
        public BookValidator()
        {
            RuleFor(x => x.Name).NotEmpty().NotNull().WithMessage("Required Field!")
                .MaximumLength(15).WithMessage("Maximum 15 character");
            When(x => x.Name == "Deneme", () =>
            {
                RuleFor(x => x.PageCount).Must(y => y == "50").WithMessage("If name is Deneme, pagecount should be 50");
            });
            RuleFor(x => x.PageCount).Must(y => int.TryParse(y, out int value)).WithMessage("Please express the page with a number");

            //RuleFor(x => x.PageCount).Must(y => y is int).WithMessage("Please express the page with a number");
        }
    }
}
