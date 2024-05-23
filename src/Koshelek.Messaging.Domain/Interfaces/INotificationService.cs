using Koshelek.Messaging.Domain.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Koshelek.Messaging.Domain.Interfaces
{
    public interface INotificationService : ITransientService
    {
        Task BroadcastAsync(INotificationMessage notification, CancellationToken cancellationToken);
        Task SendToGroupAsync(INotificationMessage notification, string group, CancellationToken cancellationToken);
    }
}
