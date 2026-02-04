using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record TranscriptionResult
{
    [JsonPropertyName("transcript")]
    public IEnumerable<Transcript> Transcript { get; set; } = new List<Transcript>();
}
