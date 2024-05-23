using Koshelek.Messaging.Domain;
using Koshelek.Messaging.Domain.Entities;

namespace Koshelek.Messaging.Application.Messages.Queries
{
    public sealed class GetMessagesResponse : Response<IReadOnlyList<Message>>;
}
