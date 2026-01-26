using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record CreateStreamOut
{
    [JsonPropertyName("stream_id")]
    public required int StreamId { get; set; }

    [JsonPropertyName("stream_url_for_languages")]
    public IEnumerable<StreamUrlForLanguages> StreamUrlForLanguages { get; set; } =
        new List<StreamUrlForLanguages>();

    [JsonPropertyName("task_id")]
    public required string TaskId { get; set; }
}
