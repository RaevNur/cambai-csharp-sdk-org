using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record TargetStream
{
    [JsonPropertyName("languages")]
    public IEnumerable<int> Languages { get; set; } = new List<int>();

    [JsonPropertyName("url")]
    public required string Url { get; set; }

    [JsonPropertyName("type")]
    public required int Type { get; set; }

    [JsonPropertyName("passphrase")]
    public string? Passphrase { get; set; }

    [JsonPropertyName("streamid")]
    public string? Streamid { get; set; }

    [JsonPropertyName("pids")]
    public IEnumerable<int>? Pids { get; set; }

    [JsonPropertyName("transcode_video")]
    public bool? TranscodeVideo { get; set; }

    [JsonPropertyName("embed_subtitles")]
    public bool? EmbedSubtitles { get; set; }

    [JsonPropertyName("audio_codec")]
    public string? AudioCodec { get; set; }

    [JsonPropertyName("audio_bitrate")]
    public string? AudioBitrate { get; set; }

    [JsonPropertyName("audio_channel_layout")]
    public string? AudioChannelLayout { get; set; }

    [JsonPropertyName("latency")]
    public int? Latency { get; set; }

    [JsonPropertyName("constant_bitrate")]
    public bool? ConstantBitrate { get; set; }

    [JsonPropertyName("relay_output")]
    public bool? RelayOutput { get; set; }
}
