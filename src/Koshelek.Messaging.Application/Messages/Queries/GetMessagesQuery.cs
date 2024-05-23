using Koshelek.Messaging.Domain.Entities;
using MediatR;

namespace Koshelek.Messaging.Application.Messages.Queries
{
    public sealed class GetMessagesQuery : IRequest<IReadOnlyList<Message>>
    {
        public DateTime From { get; init; }
        public DateTime To { get; init; }

        public int PageNumber { get; init; }
        public int PageSize { get; init; }

    }
}
