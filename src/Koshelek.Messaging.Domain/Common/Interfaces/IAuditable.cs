namespace Koshelek.Messaging.Domain.Common.Interfaces
{
    public interface IAuditable
    {
        DateTime CreateAt { get; init; }
        DateTime UpdateAt { get; set; }
    }
}
