using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record Transcript
{
    [JsonPropertyName("start")]
    public required double Start { get; set; }

    [JsonPropertyName("end")]
    public required double End { get; set; }

    [JsonPropertyName("text")]
    public required string Text { get; set; }

    [JsonPropertyName("speaker")]
    public required string Speaker { get; set; }
}
