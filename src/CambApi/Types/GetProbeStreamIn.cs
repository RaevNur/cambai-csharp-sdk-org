using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record GetProbeStreamIn
{
    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; set; }

    [JsonPropertyName("stream_id")]
    public string? StreamId { get; set; }
}
