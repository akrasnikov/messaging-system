using Koshelek.Messaging.Application.Converters;
using Koshelek.Messaging.Domain.Common.Interfaces;
using Koshelek.Messaging.Domain.Entities;
using MediatR;
using System.Text.Json.Serialization;

namespace Koshelek.Messaging.Application.Messages.Queries
{
    public sealed class GetMessagesQuery : IRequest<IReadOnlyList<Message>>, ICacheable
    {
        [JsonConverter(typeof(ShortDateTimeJsonConverter))]
        public DateTime From { get; init; }

        [JsonConverter(typeof(ShortDateTimeJsonConverter))]
        public DateTime To { get; init; }

        public int PageNumber { get; init; }
        public int PageSize { get; init; }

    }
}
