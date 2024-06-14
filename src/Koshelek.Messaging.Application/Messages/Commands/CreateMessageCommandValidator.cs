using FluentValidation;

namespace Koshelek.Messaging.Application.Messages.Commands
{
    public class CreateMessageCommandValidator : AbstractValidator<CreateMessageCommand>
    {
        public CreateMessageCommandValidator()
        {
            RuleFor(command => command.Id)
            .NotNull()                      
            .WithMessage("The number can't be null."); 

            RuleFor(command => command.Text)
                .NotNull()
                .NotEmpty()                 
                .WithMessage("The shipping method can't be null or empty.");

            RuleFor(command => command.Text)                
               .MaximumLength(256)
               .WithMessage("The Text can't be more than 256 characters.");

        }
    }
}
