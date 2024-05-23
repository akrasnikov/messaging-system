using Koshelek.Messaging.Domain.Common.Interfaces;
using System.Text.Json;


namespace Koshelek.Messaging.Domain.Common.Services;

public class MicrosoftSerializerService : ISerializerService
{
    public T Deserialize<T>(string text)
    {
        if (string.IsNullOrWhiteSpace(text))
        {
            throw new ArgumentException($"'{nameof(text)}' cannot be null or whitespace.", nameof(text));
        }

        return JsonSerializer.Deserialize<T>(text) ?? throw new Exception("deserialize");

    }

    public string Serialize<T>(T obj)
    {
        return JsonSerializer.Serialize(obj);

    }
}