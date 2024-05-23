using MediatR;

namespace Koshelek.Messaging.Application.Abstractions
{
    public sealed class CreateCommand<T> : IRequest<CreateResponse> where T : class
    {
        public T? Data { get; init; }

    }
}
