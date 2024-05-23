using Koshelek.Messaging.Events.Contracts;
using MassTransit;

namespace Koshelek.Message.Worker.Events.Consumers
{
    public class GetMessagesConsumer : IConsumer<GetMessagesIntegrationEvent>
    {
        private readonly ILogger<GetMessagesConsumer> _logger;

        public GetMessagesConsumer(ILogger<GetMessagesConsumer> logger)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        public async Task Consume(ConsumeContext<GetMessagesIntegrationEvent> context)
        {

            await Task.CompletedTask;
        }
    }
}
