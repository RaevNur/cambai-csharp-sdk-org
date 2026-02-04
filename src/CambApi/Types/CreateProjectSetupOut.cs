using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record CreateProjectSetupOut
{
    [JsonPropertyName("task_id")]
    public required string TaskId { get; set; }
}
