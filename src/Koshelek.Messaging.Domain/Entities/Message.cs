using Koshelek.Messaging.Domain.Common.Interfaces;

namespace Koshelek.Messaging.Domain.Entities
{
#nullable disable
    public class Message : IAuditable, ISoftDelete
    {
        public uint Id { get; init; }
        public string Text { get; init; }
        public bool IsDeleted { get; set; }
        public DateTime CreateAt { get; init; }
        public DateTime UpdateAt { get; set; }
    }
}
