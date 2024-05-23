using FluentValidation;

namespace Koshelek.Messaging.Application.Messages.Queries
{
    public class GetMessagesQueryValidator : AbstractValidator<GetMessagesQuery>
    {
        public GetMessagesQueryValidator()
        {
            RuleFor(query => query.From)
                .NotNull()
                .NotEmpty()
                .WithMessage("The DateTime can't be null or empty.");

            RuleFor(query => query.To)
                .NotNull()
                .NotEmpty()
                .WithMessage("The DateTime can't be null or empty.");

            RuleFor(query => query.PageNumber)
                .NotNull()
                .NotEmpty()
                .LessThan(1)
               .WithMessage("The PageNumber can't be null or empty or less than 1.");

            RuleFor(query => query.PageSize)
                .NotNull()
                .NotEmpty()
                .LessThan(1)
               .WithMessage("The PageSize can't be null or empty or less than 1.");

        }
    }
}
