using System.Text.Json.Serialization;
using CambApi.Core;
using OneOf;

#nullable enable

namespace CambApi;

public record OrchestratorPipelineResult
{
    [JsonPropertyName("status")]
    public required TaskStatus Status { get; set; }

    [JsonPropertyName("run_id")]
    public int? RunId { get; set; }

    [JsonPropertyName("exception_reason")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<string, ExceptionReasons>>))]
    public OneOf<string, ExceptionReasons>? ExceptionReason { get; set; }

    [JsonPropertyName("message")]
    [JsonConverter(typeof(OneOfSerializer<OneOf<Dictionary<string, object?>, string>>))]
    public OneOf<Dictionary<string, object?>, string>? Message { get; set; }
}
