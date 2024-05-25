using Koshelek.Messaging.Domain.Entities;
using Koshelek.Messaging.Domain.Interfaces.Notifications;
using Koshelek.Messaging.Domain.Interfaces.Repositories;
using Koshelek.Messaging.Events.Contracts;
using Koshelek.Messaging.Worker.Notifications;
using MassTransit;

namespace Koshelek.Messaging.Worker.Events.Consumers
{
    public class CreateMessageConsumer : IConsumer<CreateMessageIntegrationEvent>
    {
        public IMessagesRepository _messagesRepository;
        public INotificationService _notificationService;
        private readonly ILogger<CreateMessageConsumer> _logger;

        public CreateMessageConsumer(ILogger<CreateMessageConsumer> logger,
            IMessagesRepository messagesRepository,
            INotificationService notificationService)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _messagesRepository = messagesRepository ?? throw new ArgumentNullException(nameof(messagesRepository));
            _notificationService = notificationService ?? throw new ArgumentNullException(nameof(notificationService));
        }

        public async Task Consume(ConsumeContext<CreateMessageIntegrationEvent> context)
        {

            var message = new Message()
            {
                Id = context.Message.Id,
                Text = context.Message.Text,
                CreateAt = context.Message.CreateAt
            };

            await _messagesRepository.CreateAsync(message, context.CancellationToken); 

            await _notificationService.BroadcastAsync(new BasicNotification()
            {
                Label = BasicNotification.LabelType.Success,
                Id = context.Message.Id,
                Text = context.Message.Text,
                CreateAt = context.Message.CreateAt
            }, context.CancellationToken);
        }
    }
}
