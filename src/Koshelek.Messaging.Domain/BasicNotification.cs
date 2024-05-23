﻿namespace Koshelek.Messaging.Domain;

public class BasicNotification : INotificationMessage
{
    public enum LabelType
    {
        Information,
        Success,
        Warning,
        Error
    }

    
    public LabelType Label { get; set; }
    public uint Id { get; set; }
    public string? Text { get; set; }
    public DateTime CreateAt { get; set; }
}