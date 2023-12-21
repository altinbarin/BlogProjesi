using Blog.Entity.Entities;
using FluentValidation;

namespace Blog.Service.FluentValidations
{
    public class CategoryValidator: AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.Name)
                .NotEmpty()
                .NotNull()
                .MinimumLength(3)
                .MaximumLength(100)
                .WithName("Kategori Adı");
        }
    }
}
