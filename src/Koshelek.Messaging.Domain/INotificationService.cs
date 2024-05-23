using Koshelek.Messaging.Domain.Common.Interfaces;

namespace Koshelek.Messaging.Domain
{
    public interface INotificationService : ITransientService
    {
        Task BroadcastAsync(INotificationMessage notification, CancellationToken cancellationToken);
        Task SendToGroupAsync(INotificationMessage notification, string group, CancellationToken cancellationToken);
    }
}
