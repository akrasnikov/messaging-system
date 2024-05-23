using Koshelek.Messaging.Events.Contracts;
using MassTransit;

namespace Koshelek.Message.Worker.Events.Consumers
{
    public class CreateMessageConsumer : IConsumer<CreateMessageIntegrationEvent>
    { 
        private readonly ILogger<CreateMessageConsumer> _logger;

        public CreateMessageConsumer(ILogger<CreateMessageConsumer> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Consume(ConsumeContext<CreateMessageIntegrationEvent> context)
        {
             

        }
    }
}
