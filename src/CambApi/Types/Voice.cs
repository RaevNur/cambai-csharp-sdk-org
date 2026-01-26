using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record Voice
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("voice_name")]
    public required string VoiceName { get; set; }

    [JsonPropertyName("gender")]
    public int? Gender { get; set; }

    [JsonPropertyName("age")]
    public int? Age { get; set; }

    [JsonPropertyName("language")]
    public int? Language { get; set; }

    [JsonPropertyName("transcript")]
    public string? Transcript { get; set; }

    [JsonPropertyName("description")]
    public string? Description { get; set; }

    [JsonPropertyName("is_published")]
    public bool? IsPublished { get; set; }

    [JsonPropertyName("signed_url")]
    public string? SignedUrl { get; set; }
}
