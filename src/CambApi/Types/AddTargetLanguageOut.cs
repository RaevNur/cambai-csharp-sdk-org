using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record AddTargetLanguageOut
{
    [JsonPropertyName("message")]
    public required string Message { get; set; }

    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
