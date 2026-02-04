using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record OrchestratorPipelineCallResult
{
    [JsonPropertyName("task_id")]
    public string? TaskId { get; set; }
}
