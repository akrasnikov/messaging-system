using Koshelek.Messaging.Domain.Common.Interfaces;
using MediatR;

namespace Koshelek.Messaging.Application.Messages.Commands
{
    public sealed class CreateMessageCommand : IRequest<CreateMessageResponse>
    {
        public int Id { get; init; }
        public string Text { get; init; } = string.Empty;
    }
}
