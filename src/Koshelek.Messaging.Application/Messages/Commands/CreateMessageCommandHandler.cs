using Koshelek.Messaging.Events.Contracts;
using MassTransit;
using MediatR;

namespace Koshelek.Messaging.Application.Messages.Commands
{
    public sealed class CreateMessageCommandHandler : IRequestHandler<CreateMessageCommand, CreateMessageResponse>
    {

        readonly IBus _bus;
        public CreateMessageCommandHandler(IBus bus)
        {
            _bus = bus ?? throw new ArgumentNullException(nameof(bus));
        }

        public async Task<CreateMessageResponse> Handle(CreateMessageCommand request, CancellationToken cancellationToken)
        {
            var message = new CreateMessageIntegrationEvent
            {
                Id = request.Id,
                Text = request.Text,
                CreateAt = DateTime.UtcNow
            };
            await _bus.Publish(message, cancellationToken);

            return new CreateMessageResponse()
            {
                Success = true
            };
        }
    }
}
