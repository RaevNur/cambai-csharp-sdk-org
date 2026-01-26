using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record VideoStream
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

    [JsonPropertyName("width")]
    public int? Width { get; set; }

    [JsonPropertyName("height")]
    public int? Height { get; set; }

    [JsonPropertyName("is_avc")]
    public bool? IsAvc { get; set; }

    [JsonPropertyName("id")]
    public string? Id { get; set; }
}
