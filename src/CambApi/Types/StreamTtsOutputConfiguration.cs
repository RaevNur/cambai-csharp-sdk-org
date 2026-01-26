using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record StreamTtsOutputConfiguration
{
    [JsonPropertyName("format")]
    public OutputFormat? Format { get; set; }

    [JsonPropertyName("duration")]
    public double? Duration { get; set; }

    [JsonPropertyName("apply_enhancement")]
    public bool? ApplyEnhancement { get; set; }
}
