using System.Text.Json.Serialization;

#nullable enable

namespace CambApi;

public record TermTranslationInput
{
    [JsonPropertyName("translation")]
    public required string Translation { get; set; }

    [JsonPropertyName("language")]
    public required int Language { get; set; }
}
