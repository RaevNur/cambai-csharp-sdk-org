using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record DataStream
{
    [JsonPropertyName("index")]
    public required int Index { get; set; }

    [JsonPropertyName("codec_name")]
    public string? CodecName { get; set; }

    [JsonPropertyName("codec_long_name")]
    public string? CodecLongName { get; set; }

    [JsonPropertyName("codec_tag_string")]
    public string? CodecTagString { get; set; }

    [JsonPropertyName("codec_tag")]
    public string? CodecTag { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
