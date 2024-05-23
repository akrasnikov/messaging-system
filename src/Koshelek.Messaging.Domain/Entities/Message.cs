namespace Koshelek.Messaging.Domain.Entities
{
#nullable disable
    public class Message
    {
        public uint Id { get; set; }
        public string Text { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
