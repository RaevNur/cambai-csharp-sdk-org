using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record AudioStream
{
    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("codec_name")]
    public required string CodecName { get; set; }

    [JsonPropertyName("codec_long_name")]
    public required string CodecLongName { get; set; }

    [JsonPropertyName("codec_tag_string")]
    public string? CodecTagString { get; set; }

    [JsonPropertyName("codec_tag")]
    public string? CodecTag { get; set; }

    [JsonPropertyName("profile")]
    public string? Profile { get; set; }

    [JsonPropertyName("sample_fmt")]
    public required string SampleFmt { get; set; }

    [JsonPropertyName("sample_rate")]
    public required int SampleRate { get; set; }

    [JsonPropertyName("channels")]
    public required int Channels { get; set; }

    [JsonPropertyName("channel_layout")]
    public string? ChannelLayout { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("bit_rate")]
    public int? BitRate { get; set; }

    [JsonPropertyName("tags")]
    public Dictionary<string, object?>? Tags { get; set; }
}
