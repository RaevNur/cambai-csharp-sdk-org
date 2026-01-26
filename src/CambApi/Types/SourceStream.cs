using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record SourceStream
{
    [JsonPropertyName("language")]
    public required int Language { get; set; }

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("category")]
    public int? Category { get; set; }

    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; set; }

    [JsonPropertyName("streamid")]
    public string? Streamid { get; set; }

    [JsonPropertyName("number_of_streams")]
    public int? NumberOfStreams { get; set; }

    [JsonPropertyName("audio_stream")]
    public int? AudioStream { get; set; }

    [JsonPropertyName("background_audio_stream")]
    public int? BackgroundAudioStream { get; set; }

    [JsonPropertyName("latency")]
    public int? Latency { get; set; }

    [JsonPropertyName("relay_input")]
    public bool? RelayInput { get; set; }
}
