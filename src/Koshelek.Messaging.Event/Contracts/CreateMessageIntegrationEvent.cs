namespace Koshelek.Messaging.Events.Contracts
{
    public sealed class CreateMessageIntegrationEvent
    {
        public int Id { get; set; }
        public string Text { get; set; }
        public DateTime CreateAt { get; set; }
    }
}
