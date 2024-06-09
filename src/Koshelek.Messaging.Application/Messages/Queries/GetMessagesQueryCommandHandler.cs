using Koshelek.Messaging.Domain.Entities;
using Koshelek.Messaging.Domain.Interfaces.Repositories;
using MediatR;

namespace Koshelek.Messaging.Application.Messages.Queries
{
    public sealed class GetMessagesQueryCommandHandler : IRequestHandler<GetMessagesQuery, IReadOnlyList<Message>>
    {
        public IMessagesRepository _messagesRepository;
        public GetMessagesQueryCommandHandler(IMessagesRepository messagesRepository)
        {
            _messagesRepository = messagesRepository ?? throw new ArgumentNullException(nameof(messagesRepository));
        }

        public async Task<IReadOnlyList<Message>> Handle(GetMessagesQuery request, CancellationToken cancellationToken)
        { 
            return await _messagesRepository.FindAsync(
                message => message.CreatedAt > request.From && message.CreatedAt < request.To, 
                request.PageNumber,
                request.PageSize,
                cancellationToken);
        }
    }
}
