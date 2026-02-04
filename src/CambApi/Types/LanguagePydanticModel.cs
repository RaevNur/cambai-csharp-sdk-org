using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record LanguagePydanticModel
{
    [JsonPropertyName("id")]
    public required int Id { get; set; }

    [JsonPropertyName("language")]
    public required string Language { get; set; }

    [JsonPropertyName("short_name")]
    public required string ShortName { get; set; }
}
