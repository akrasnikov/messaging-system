using Koshelek.Messaging.Domain.Entities;
using MediatR;

namespace Koshelek.Messaging.Application.Messages.Queries
{
    public sealed class GetMessagesQueryCommandHandler : IRequestHandler<GetMessagesQuery, IReadOnlyList<Message>>
    {

        public GetMessagesQueryCommandHandler()
        {

        }

        public Task<IReadOnlyList<Message>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
