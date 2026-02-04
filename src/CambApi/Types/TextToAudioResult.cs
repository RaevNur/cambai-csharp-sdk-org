using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record TextToAudioResult
{
    [JsonPropertyName("output_url")]
    public required string OutputUrl { get; set; }
}
