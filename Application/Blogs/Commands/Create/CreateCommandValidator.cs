using FluentValidation;

namespace Application.Blogs.Commands.Create
{
    public class CreateCommandValidator : AbstractValidator<CreateCommand>
    {
        public CreateCommandValidator()
        {
            RuleFor(v => v.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(200).WithMessage("Name must not exceed 200 characters");

            RuleFor(v => v.Description)
                .NotEmpty().WithMessage("Description is required");

            RuleFor(v => v.Name)
                .NotEmpty().WithMessage("Name is required")
                .MaximumLength(25).WithMessage("Author name must not exceed 25 character");
        }
    }
}
