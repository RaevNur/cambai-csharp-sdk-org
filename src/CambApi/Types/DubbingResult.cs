using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record DubbingResult
{
    [JsonPropertyName("audio_url")]
    public required string AudioUrl { get; set; }

    [JsonPropertyName("transcript")]
    public IEnumerable<Transcript> Transcript { get; set; } = new List<Transcript>();

    [JsonPropertyName("video_url")]
    public string? VideoUrl { get; set; }
}
